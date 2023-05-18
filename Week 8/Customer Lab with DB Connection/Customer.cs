using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting;

namespace Customer_Lab
{
    public class Customer: PersonV2
    {
        private DateTime _customerSince;
        private double _totalPurchases;
        private bool _discountMember;
        private int _rewardsEarned;

        public DateTime CustomerSince
        {
            get { return _customerSince; }
            set
            {
                if (Validations.IsNotAFutureDate(value)==false)
                {
                    Feedback += "\nERROR: Cannot enter date before today";
                }
                else
                {
                    _customerSince = value;
                }
            }
        }

        public double TotalPurchases
        {
            get { return _totalPurchases; }
            set
            {
                if (Validations.IsADouble(value.ToString()) == false)
                {
                    Feedback += "\nERROR: Total Purchases must be a number";
                }
                else if (Validations.IsItFilledIn(value.ToString(), 1) == false)
                {
                    Feedback += "\nERROR: Total Purchases must contain atleast one digit";
                }
                else
                {
                    _totalPurchases = value;
                }
            }
        }

        public bool DiscountMember
        {
            get { return _discountMember; }
            set { _discountMember = value; }
        }

        public int RewardsEarned
        {
            get { return _rewardsEarned; }
            set
            {
                if (Validations.IsAnInteger(value.ToString()) == false)
                {
                    Feedback += "\nERROR: Rewards Earned must be an integer";
                }

                if (Validations.IsItFilledIn(value.ToString(), 1) == false)
                {
                    Feedback += "\nERROR: Rewards Earned must contain atleast one digit";
                }
                else
                {
                    _rewardsEarned = value;
                }
            }
        }

        public string AddARecord()
        {
            string strResult = "";
            SqlConnection Conn = new SqlConnection();
            
            Conn.ConnectionString = 
                @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE133_TKnott;User ID=SE133_TKnott;Password=008018683";

            string strSQL =
                "INSERT INTO CustomersV2 (First_Name, Middle_Initial, Last_Name, Street1, Street2, City, State, Zipcode, Phone, Cell_Phone, Email, Instagram_URL, Customer_Since, Total_Purchases, Discount_Member, Rewards_Earned)" +
                "VALUES (@First_Name, @Middle_Initial, @Last_Name, @Street1, @Street2, @City, @State, @Zipcode, @Phone, @Cell_Phone, @Email, @Instagram_URL, @Customer_Since, @Total_Purchases, @Discount_Member, @Rewards_Earned)";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@First_Name", FName);
            comm.Parameters.AddWithValue("@Middle_Initial", MName);
            comm.Parameters.AddWithValue("@Last_Name", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zipcode", ZipCode);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Cell_Phone", CellPhone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Instagram_URL", InstagramURL);
            comm.Parameters.AddWithValue("@Customer_Since", CustomerSince);
            comm.Parameters.AddWithValue("@Total_Purchases", TotalPurchases);
            comm.Parameters.AddWithValue("@Discount_Member", DiscountMember);
            comm.Parameters.AddWithValue("@Rewards_Earned", RewardsEarned);

            try
            {
                Conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                strResult = "SUCCESS: Connected to Database";
                Conn.Close();
            }

            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            
            finally{}

            return strResult;
        }
    }
}