using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryBooks.WebUI.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }

    public class BookDetailViewModel
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }

    public class BookEditViewModel
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}