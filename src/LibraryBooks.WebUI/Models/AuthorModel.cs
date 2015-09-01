using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryBooks.WebUI.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class AuthorDetailViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}