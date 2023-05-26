using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonV2_Lab
{
    public class PersonV2: Person
    {
        private string _cellPhone;
        private string _instagramURL;
        private int _personID;
//**********************************************************************************************************************
        public string CellPhone
        {
            get { return _cellPhone; }
            set
            {
                if (Validations.NullorEmpty(value) == true)
                {
                    _cellPhone = value;
                }
                else if (Validations.IsADouble(value)==false)
                {
                    Feedback += "\nERROR: Cellphone must only contain numbers";
                }
                else if (Validations.ExactLength(value, 10)==false)
                {
                    Feedback += "\nERROR: Cellphone must contain 10 numbers";
                }
                else
                {
                    _cellPhone = value;
                }
            }
        }
        public string InstagramURL
        {
            get { return _instagramURL; }
            set
            {
                if (Validations.NullorEmpty(value) == true)
                {
                    _instagramURL = value;
                }
                else if (Validations.GotProfanity(value))
                {
                    Feedback += "\nYour Instagram URL cannot contain profanity";
                }
                else if (Validations.ValidInstagramURL(value)==false)
                {
                    Feedback += "\nInvalid URL to instagram";
                }
                else
                {
                    _instagramURL = value;
                }
            }
        }
        public int Person_ID
        {
            get { return _personID; }
            set { _personID = value; }
        }
//**********************************************************************************************************************
        private string GetConnected()
        {
            return @"Server=sql.neit.edu,4500;Database=SE133_TKnott;User Id=SE133_TKnott;Password=008018683;";
        }
        
        public string addRecord()
        {
            string strResult = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnected();
            
            string strSQL = "INSERT INTO PersonV2 (FName, MName, LName, Street1, Street2, City, State, Zipcode, Phone, CellPhone, Email, InstagramURL) " +
                            "VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zipcode, @Phone, @CellPhone, @Email, @InstagramURL)";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zipcode", ZipCode);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@InstagramURL", InstagramURL);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally{}

            return strResult;
        }

        public string updateRecord()
        {
            Int32 intRec = 0;
            string strResult = "";

            string strSQL = "UPDATE PersonV2 SET FName = @FName, MName = @MName, LName = @LName, Street1 = @Street1, Street2 = @Street2, City = @City, State = @State, Zipcode = @Zipcode, Phone = @Phone, CellPhone = @CellPhone, Email = @Email, InstagramURL = @InstagramURL WHERE Person_ID = @Person_ID";

            SqlConnection conn = new SqlConnection();
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@Person_ID", Person_ID);
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zipcode", ZipCode);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@InstagramURL", InstagramURL);

            try
            {
                conn.Open();
                intRec = comm.ExecuteNonQuery();
                strResult = intRec.ToString() + " Records Updated.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                conn.Close();
            }

            return strResult;
        }

        public string deleteRecord(int intPerson_ID)
        {
            int intRec = 0;
            string strResult = "";

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string sqlString = "DELETE FROM PersonV2 WHERE Person_ID = @Person_ID";

            conn.ConnectionString = GetConnected();

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            try
            {
                conn.Open();
                intRec = comm.ExecuteNonQuery();
                strResult = intRec.ToString() + " Records Deleted.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                conn.Close();
            }

            return strResult;
        }

        public DataSet SearchPerson(String strFirstName, String strMiddleName, String strLastName, String strEmail,
            String strCity, String strState, String strZipcode, String strPhone)
        {
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();

            String strSQL =
                "SELECT Person_ID, FName, MName, LName, Email, City, State, Zipcode, Phone FROM PersonV2 WHERE 0=0";

            if (strFirstName.Length > 0)
            {
                strSQL += " AND FName LIKE @FName";
                comm.Parameters.AddWithValue("@FName", "%" + strFirstName + "%");
            }
            if (strMiddleName.Length > 0)
            {
                strSQL += " AND MName LIKE @MName";
                comm.Parameters.AddWithValue("@MName", "%" + strMiddleName + "%");
            }
            if (strLastName.Length > 0)
            {
                strSQL += " AND LName LIKE @LName";
                comm.Parameters.AddWithValue("@LName", "%" + strLastName + "%");
            }
            if (strEmail.Length > 0)
            {
                strSQL += " AND Email LIKE @Email";
                comm.Parameters.AddWithValue("@Email", "%" + strEmail + "%");
            }
            if (strCity.Length > 0)
            {
                strSQL += " AND City LIKE @City";
                comm.Parameters.AddWithValue("@City", "%" + strCity + "%");
            }
            if (strState.Length > 0)
            {
                strSQL += " AND State LIKE @State";
                comm.Parameters.AddWithValue("@State", "%" + strState + "%");
            }
            if (strZipcode.Length > 0)
            {
                strSQL += " AND Zipcode LIKE @Zipcode";
                comm.Parameters.AddWithValue("@Zipcode", "%" + strZipcode + "%");
            }
            if (strPhone.Length > 0)
            {
                strSQL += " AND Phone LIKE @Phone";
                comm.Parameters.AddWithValue("@Phone", "%" + strPhone + "%");
            }
            //*****************************************************************************
            SqlConnection conn = new SqlConnection();
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            //*****************************************************************************
            conn.Open();
            da.Fill(ds, "Person_Temp");
            conn.Close();

            return ds;
        }

        public SqlDataReader findPerson(int intPerson_ID)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = GetConnected();

            string sqlString = "SELECT * FROM PersonV2 WHERE Person_ID = @Person_ID";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);
            
            conn.Open();

            return comm.ExecuteReader();
        }
    }
}