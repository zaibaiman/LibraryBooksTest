using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Model
{
    class BookModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual AuthorModel Author { get; set; }
        public virtual CategoryModel Category { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
