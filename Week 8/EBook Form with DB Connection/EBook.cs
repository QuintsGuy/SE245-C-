using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting;
using Form_Demo;

namespace Form_Demo
{
    public class EBook: Book
    {
        private DateTime dateRentalExpires;
        private int bookmarkPage;
        private bool member;

        public DateTime DateRentalExpires
        {
            get { return dateRentalExpires; }
            set 
            {
                if (Validation.IsAFutureDate(value))
                {
                    dateRentalExpires = value;
                }
                else
                {
                    feedback += "\nERROR: You must enter future dates";
                }
            }
        }

        public int BookmarkPage
        {
            get { return bookmarkPage; }
            set
            {
                if (Validation.IsAnInteger(value.ToString()) && value >= 0 && value <= Pages)
                {
                    bookmarkPage = value;
                }
                else
                {
                    Feedback += "\nERROR: Sorry you entered an invalid bookmark page #.";
                }
            }
        }

        public bool Member
        {
            get { return member; }
            set { member = value; }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_TKnott;User Id=SE133_TKnott;Password=008018683;";
        }
        
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        public string AddARecord()
        {
            string strResult = "";
            
            SqlConnection Conn = new SqlConnection();
            
            Conn.ConnectionString = @GetConnected();
            
            string strSQL = "INSERT INTO EBooks (Title, AuthorFirst, AuthorLast, Email, Pages, DatePublished, DateRentalExpires, BookmarkPage) " +
                            "VALUES (@Title, @AuthorFirst, @AuthorLast, @Email, @Pages, @DatePublished, @DateRentalExpires, @BookmarkPage)";
            
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            
            comm.Parameters.AddWithValue("@Title", Title);
            comm.Parameters.AddWithValue("@AuthorFirst", AuthorFirstName);
            comm.Parameters.AddWithValue("@AuthorLast", AuthorLastName);
            comm.Parameters.AddWithValue("@Email", AuthorEmail);
            comm.Parameters.AddWithValue("@Pages", Pages);
            comm.Parameters.AddWithValue("@DatePublished", PubDate);
            comm.Parameters.AddWithValue("@DateRentalExpires", DateRentalExpires);
            comm.Parameters.AddWithValue("@BookmarkPage", BookmarkPage);
            
            try
            {
                Conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records."; 
                Conn.Close();
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {

            }
            
            return strResult;
        }
        
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public DataSet SearchEBooks(string strTitle, string strAuthorLast)
        {
            
            DataSet ds = new DataSet();
            
            SqlCommand comm = new SqlCommand();
            
            String strSQL = "SELECT EBook_ID, Title, AuthorFirst, AuthorLast FROM EBooks WHERE 0=0";
            
            if (strTitle.Length > 0)
            {
                strSQL += " AND Title LIKE @Title";
                comm.Parameters.AddWithValue("@Title", "%" + strTitle + "%");
            }
            if (strAuthorLast.Length > 0)
            {
                strSQL += " AND AuthorLast LIKE @AuthorLast";
                comm.Parameters.AddWithValue("@AuthorLast", "%" + strAuthorLast + "%");
            }
            
            SqlConnection conn = new SqlConnection();
            
            string strConn = @GetConnected();
            conn.ConnectionString = strConn;
            
            comm.Connection = conn;
            comm.CommandText = strSQL;
            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "EBooks_Temp");
            conn.Close();               
            
            return ds;
        }
        
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        public SqlDataReader FindOneEBook(int intEBook_ID)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            
            string strConn = GetConnected();
            
            string sqlString =
                "SELECT * FROM EBooks WHERE EBook_ID = @EBook_ID;";
            
            conn.ConnectionString = strConn;
            
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@EBook_ID", intEBook_ID);
            
            conn.Open();
            return comm.ExecuteReader();
        }
        
        public EBook() : base()
        {
            BookmarkPage = 0;
            dateRentalExpires = DateTime.Now.AddDays(14);
        }
    }
}