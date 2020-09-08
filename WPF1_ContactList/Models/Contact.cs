using System;
using System.Collections.Generic;
using System.Text;

namespace WPF1_ContactList.Models
{
    class Contact
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname => $"{Firstname} {Lastname}";


        public Contact(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
