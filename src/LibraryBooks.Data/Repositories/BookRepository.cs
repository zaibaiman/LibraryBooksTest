using LibraryBooks.Domain.Entities;
using LibraryBooks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<BookEntity> bookList = new List<BookEntity>();

        public BookRepository()
        {
            bookList.Add(new BookEntity { Id = 0, ISBN="978-3-16-148410-0", Name = "Pancho Villa", Price = 120 });
            bookList.Add(new BookEntity { Id = 1, ISBN = "764-3-16-12222-0", Name = "El Quijote", Price = 240 });
            bookList.Add(new BookEntity { Id = 2, ISBN = "468-3-16-33333-0", Name = "Siete Luneas", Price = 320 });
        }

        public IEnumerable<BookEntity> FindAll()
        {
            List<BookEntity> newList = new List<BookEntity>();
            foreach (BookEntity bookEntity in bookList)
            {
                newList.Add(Clone(bookEntity));
            }
            return newList;
        }

        public BookEntity FindById(int id)
        {
            foreach (BookEntity bookEntity in bookList)
            {
                if (bookEntity.Id == id) return bookEntity;
            }
            return null;
        }

        public void Create(BookEntity bookEntity)
        {
            var newBook = Clone(bookEntity);
            newBook.Id = bookList.Count;
            bookList.Add(newBook);
        }

        public void Update(BookEntity bookEntity)
        {
            BookEntity savedEntity = FindById(bookEntity.Id);
            savedEntity.Id = bookEntity.Id;
            savedEntity.ISBN = bookEntity.ISBN;
            savedEntity.Name = bookEntity.Name;
            savedEntity.Price = bookEntity.Price;
            savedEntity.AuthorId = bookEntity.AuthorId;
            savedEntity.CategoryId = bookEntity.CategoryId;
        }

        public void Delete(BookEntity bookEntity)
        {
            BookEntity savedEntity = FindById(bookEntity.Id);
            bookList.Remove(savedEntity);
        }

        private BookEntity Clone(BookEntity bookEntity)
        {
            BookEntity newEntity = new BookEntity();
            newEntity.Id = bookEntity.Id;
            newEntity.ISBN = bookEntity.ISBN;
            newEntity.Name = bookEntity.Name;
            newEntity.Price = bookEntity.Price;
            newEntity.AuthorId = bookEntity.AuthorId;
            newEntity.CategoryId = bookEntity.CategoryId;
            return newEntity;
        }
    }
}
