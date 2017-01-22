using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AddressBook.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace AddressBook.DAL
{
    public class AddressBookSQLDAL : IAddressBookDAL
    {
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Address Book"].ConnectionString;
        //private readonly string ConnectionString;
        //public AddressBookSQLDAL(string ConnectionString)
        //{
        //    this.ConnectionString = ConnectionString;
        //}

        public bool AddInformation(AddressBookModel newInfo)
        {
            int rowsAffected = 0;
            AddressBookModel model = new AddressBookModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Insert into Information Values(@first_name, @middle_name, @last_name, @professional_title, @age, @home_address, @work_address, @other_address, @home_phone_number, @work_phone_number, @mobile_phone_number, @personal_email_address, @work_email_address, @other_email_address, @linkedin, @website, @twitter, @facebook)", conn);
                    cmd.Parameters.AddWithValue("@first_name", newInfo.FirstName);
                    cmd.Parameters.AddWithValue("@middle_name", newInfo.MiddleName);
                    cmd.Parameters.AddWithValue("@last_name", newInfo.LastName);
                    cmd.Parameters.AddWithValue("@professional_title", newInfo.ProfessionalTitle);
                    cmd.Parameters.AddWithValue("@age", newInfo.Age);
                    cmd.Parameters.AddWithValue("@home_address", newInfo.HomeAddress);
                    cmd.Parameters.AddWithValue("@work_address", newInfo.WorkAddress);
                    cmd.Parameters.AddWithValue("@other_address", newInfo.OtherAddress);
                    cmd.Parameters.AddWithValue("@home_phone_number", newInfo.HomePhoneNumber);
                    cmd.Parameters.AddWithValue("@work_phone_number", newInfo.WorkPhoneNumber);
                    cmd.Parameters.AddWithValue("@mobile_phone_number", newInfo.MobilePhoneNumber);
                    cmd.Parameters.AddWithValue("@personal_email_address", newInfo.PersonalEmailAddress);
                    cmd.Parameters.AddWithValue("@work_email_address", newInfo.WorkEmailAddress);
                    cmd.Parameters.AddWithValue("@other_email_address", newInfo.OtherEmailAddress);
                    cmd.Parameters.AddWithValue("@linkedin", newInfo.LinkedIn);
                    cmd.Parameters.AddWithValue("@website", newInfo.Website);
                    cmd.Parameters.AddWithValue("@twitter", newInfo.Twitter);
                    cmd.Parameters.AddWithValue("@facebook", newInfo.Facebook);

                    rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

        }
    }
}