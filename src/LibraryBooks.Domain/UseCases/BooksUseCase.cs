using LibraryBooks.Domain.Entities;
using LibraryBooks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Domain.UseCases
{
    public class BooksUseCase : IBooksUseCase
    {
        private IBookRepository bookRepository;

        public BooksUseCase(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IEnumerable<BookDto> GetBooks()
        {
            var result = new List<BookDto>();
            foreach (var bookEntity in this.bookRepository.FindAll())
            {
                var bookDto = new BookDto();
                bookDto.Id = bookEntity.Id;
                bookDto.ISBN = bookEntity.ISBN;
                bookDto.Name = bookEntity.Name;
                bookDto.Price = bookEntity.Price;
                result.Add(bookDto);
            }
            return result;
        }

        public BookDto GetBookDetail(int id)
        {
            var bookEntity = this.bookRepository.FindById(id);
            return new BookDto
            {
                Id = bookEntity.Id,
                ISBN=bookEntity.ISBN,
                Name = bookEntity.Name,
                Price = bookEntity.Price
            };
        }

        public void Create(BookSaveDto bookDto)
        {
            var bookEntity = new BookEntity
            {
                Id = bookDto.Id,
                AuthorId = bookDto.AuthorId,
                CategoryId = bookDto.CategoryId,
                ISBN = bookDto.ISBN,
                Name = bookDto.Name,
                Price = bookDto.Price
            };
            this.bookRepository.Create(bookEntity);
        }

        public void Update(BookSaveDto bookDto)
        {
            var bookEntity = new BookEntity
            {
                Id = bookDto.Id,
                AuthorId = bookDto.AuthorId,
                CategoryId = bookDto.CategoryId,
                ISBN = bookDto.ISBN,
                Name = bookDto.Name,
                Price = bookDto.Price
            };
            this.bookRepository.Update(bookEntity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
