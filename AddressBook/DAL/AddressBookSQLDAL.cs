using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AddressBook.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AddressBook.DAL
{
    public class AddressBookSQLDAL : IAddressBookDAL
    {
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Address Book"].ConnectionString;
        
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

                    if (String.IsNullOrEmpty(newInfo.MiddleName))
                    {
                        cmd.Parameters.AddWithValue("@middle_name", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@middle_name", newInfo.MiddleName);

                    }

                    cmd.Parameters.AddWithValue("@last_name", newInfo.LastName);
                    
                    if (String.IsNullOrEmpty(newInfo.ProfessionalTitle))
                    {
                        cmd.Parameters.AddWithValue("@professional_title", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@professional_title", newInfo.ProfessionalTitle);

                    }
                    cmd.Parameters.AddWithValue("@age", newInfo.Age);
                    cmd.Parameters.AddWithValue("@home_address", newInfo.HomeAddress);
                    if (String.IsNullOrEmpty(newInfo.WorkAddress))
                    {
                        cmd.Parameters.AddWithValue("@work_address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@work_address", newInfo.WorkAddress);

                    }
                    
                    if (String.IsNullOrEmpty(newInfo.OtherAddress))
                    {
                        cmd.Parameters.AddWithValue("@other_address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@other_address", newInfo.OtherAddress);

                    }
                    cmd.Parameters.AddWithValue("@home_phone_number", newInfo.HomePhoneNumber);
                    
                    if (String.IsNullOrEmpty(newInfo.WorkPhoneNumber))
                    {
                        cmd.Parameters.AddWithValue("@work_phone_number", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@work_phone_number", newInfo.WorkPhoneNumber);

                    }
                    
                    if (String.IsNullOrEmpty(newInfo.MobilePhoneNumber))
                    {
                        cmd.Parameters.AddWithValue("@mobile_phone_number", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@mobile_phone_number", newInfo.MobilePhoneNumber);

                    }
                    
                    if (String.IsNullOrEmpty(newInfo.PersonalEmailAddress))
                    {
                        cmd.Parameters.AddWithValue("@personal_email_address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@personal_email_address", newInfo.PersonalEmailAddress);

                    }
                    
                    if (String.IsNullOrEmpty(newInfo.WorkEmailAddress))
                    {
                        cmd.Parameters.AddWithValue("@work_email_address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@work_email_address", newInfo.WorkEmailAddress);

                    }
                    
                    if (String.IsNullOrEmpty(newInfo.OtherEmailAddress))
                    {
                        cmd.Parameters.AddWithValue("@other_email_address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@other_email_address", newInfo.OtherEmailAddress);

                    }
                   
                    if (String.IsNullOrEmpty(newInfo.LinkedIn))
                    {
                        cmd.Parameters.AddWithValue("@linkedin", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@linkedin", newInfo.LinkedIn);

                    }
                    
                    if (String.IsNullOrEmpty(newInfo.Website))
                    {
                        cmd.Parameters.AddWithValue("@website", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@website", newInfo.Website);

                    }
                    
                    if (String.IsNullOrEmpty(newInfo.Twitter))
                    {
                        cmd.Parameters.AddWithValue("@twitter", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@twitter", newInfo.Twitter);

                    }
                    
                    if (String.IsNullOrEmpty(newInfo.Facebook))
                    {
                        cmd.Parameters.AddWithValue("@facebook", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@facebook", newInfo.Facebook);

                    }

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
