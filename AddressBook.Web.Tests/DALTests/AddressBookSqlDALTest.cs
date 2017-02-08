using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;
using AddressBook.DAL;
using AddressBook.Models;

namespace AddressBook.Web.Tests.DALTests
{
    [TestClass]
    public class AddressBookSQLDALTest
    {
        private TransactionScope tran;
        private string connectionString = ConfigurationManager.ConnectionStrings["Address Book"].ConnectionString;
        
        [TestInitialize]

        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Information;", conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Insert into Information values ('Joe', 'G', 'Schmo', 'Chef', 35, '1234 Fight Lane, Cleveland, OH 44115', '100 Food Drive, Cleveland, OH 44113', 'null', '1234567890', '0986543211', '2222222222', 'jgs@gmail.com', 'jgs@food.com', 'null', 'null', 'null', 'null', 'null');Select cast(Scope_Identity() as int)", conn);
                cmd2.ExecuteScalar();

            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void TestAddInformation()
        {
            AddressBookSQLDAL dal = new AddressBookSQLDAL();
            AddressBookModel model = new AddressBookModel();
           
            model.FirstName = "Martin";
            model.MiddleName = "C";
            model.LastName = "Tanner";
            model.ProfessionalTitle = "Swimmer";
            model.Age = 25;
            model.HomeAddress = "100 Candy Lane, Cleveland, OH 44115";
            model.WorkAddress = "200 Swimmer Drive, Cleveland, OH 44113";
            model.OtherAddress = "null";
            model.HomePhoneNumber = "1411411414";
            model.WorkPhoneNumber = "8988988989";
            model.MobilePhoneNumber = "7687687687";
            model.PersonalEmailAddress = "mct@gmail.com";
            model.WorkEmailAddress = "mct@swimmer.com";
            model.OtherEmailAddress = "null";
            model.LinkedIn = "null";
            model.Website = "null";
            model.Twitter = "@mctswimmer";
            model.Facebook = "null";

            bool addInfo = dal.AddInformation(model);

            Assert.IsTrue(addInfo);
        }
    }
}
