using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Domain.Entities
{
    public class BookEntity : Entity
    {
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
