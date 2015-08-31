using LibraryBooks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Domain.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<BookEntity> FindAll();
        BookEntity FindById(int id);
        void Create(BookEntity bookEntity);
        void Update(BookEntity bookEntity);
        void Delete(BookEntity bookEntity);
    }
}
