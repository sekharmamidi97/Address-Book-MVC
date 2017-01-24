using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddressBook.Models
{
    public class AddressBookModel
    {
        public int InfoId { get; set; }

        [Required(ErrorMessage ="You must enter your first name")]
        [Display(Name="First Name: ")]
        public string FirstName { get; set; }

        [Display(Name="Middle Name: ")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "You must enter your last name")]
        [Display(Name="Last Name: ")]
        public string LastName { get; set; }

        [Display(Name="Professional Title: ")]
        public string ProfessionalTitle { get; set; }

        [Required(ErrorMessage = "You must enter your age")]
        [Display(Name="Age: ")]
        public int Age { get; set; }

        [Required(ErrorMessage = "You must enter your home address")]
        [Display(Name="Home Address: ")]
        public string HomeAddress { get; set; }

        [Display(Name="Work Address: ")]
        public string WorkAddress { get; set; }

        [Display(Name ="Other Address: ")]
        public string OtherAddress { get; set; }

        [Required(ErrorMessage = "You must enter your home phone number")]
        [Display(Name="Home Phone Number: ")]
        public string HomePhoneNumber { get; set; }

        [Display(Name="Work Phone Number: ")]
        public string WorkPhoneNumber { get; set; }

        [Display(Name="Mobile Phone Number: ")]
        public string MobilePhoneNumber { get; set;}

        [Display(Name="Personal Email Address: ")]
        public string PersonalEmailAddress { get; set;}

        [Display(Name="Work Email Address: ")]
        public string WorkEmailAddress { get; set; }

        [Display(Name="Other Email Address: ")]
        public string OtherEmailAddress { get; set; }

        [Display(Name="LinkedIn: ")]
        public string LinkedIn { get; set; }

        [Display(Name="Website: ")]
        public string Website { get; set; }

        [Display(Name="Twitter: ")]
        public string Twitter { get; set; }

        [Display(Name="Facebook: ")]
        public string Facebook { get;set;}

    }
}