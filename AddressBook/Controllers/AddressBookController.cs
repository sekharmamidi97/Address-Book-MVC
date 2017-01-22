using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    public class AddressBookController : Controller
    {
        // GET: AddressBook
        public ActionResult AddressBook()
        {
            return View("AddressBook", new AddressBookModel());
        }

        public ActionResult AddressBookResults(AddressBookModel model)
        {
            return View("AddressBookResults", model);
        }
    }
}