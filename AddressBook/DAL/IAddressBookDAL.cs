using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.DAL
{
   public interface IAddressBookDAL
    {
        bool AddInformation(AddressBookModel newInfo);
    }
}
