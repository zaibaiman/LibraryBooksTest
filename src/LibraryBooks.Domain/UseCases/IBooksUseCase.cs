using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Domain.UseCases
{
    public class BookDto
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class BookSaveDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }

    public interface IBooksUseCase
    {
        IEnumerable<BookDto> GetBooks();
        BookDto GetBookDetail(int id);
        void Create(BookSaveDto bookDto);
        void Update(BookSaveDto bookDto);
        void Delete(int id);
    }
}
