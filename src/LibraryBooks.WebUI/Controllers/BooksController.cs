using LibraryBooks.Domain.UseCases;
using LibraryBooks.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryBooks.WebUI.Controllers
{
    public class BooksController : Controller
    {
        private IBooksUseCase booksUseCase;

        public BooksController(IBooksUseCase booksUseCase)
        {
            this.booksUseCase = booksUseCase;
        }

        // GET: Books bv 
        public ActionResult Index()
        {
            var books = new List<BookViewModel>();
            foreach(var bookDto in this.booksUseCase.GetBooks()) {
                books.Add(new BookViewModel { Id=bookDto.Id, Name=bookDto.Name, Price=bookDto.Price.ToString("0.00")});
            }
            return View(books);
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            var bookDto = this.booksUseCase.GetBookDetail(id);
            var book = new BookDetailViewModel { Id = bookDto.Id, ISBN=bookDto.ISBN, Name = bookDto.Name, Price = bookDto.Price.ToString("0.00") };
            return View(book);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        public ActionResult Create(BookEditViewModel viewModel)
        {
            try
            {
                var bookDto = new BookSaveDto 
                { 
                    Id = viewModel.Id,
                    AuthorId = viewModel.AuthorId,
                    Name = viewModel.Name,
                    Price = viewModel.Price
                };
                this.booksUseCase.Create(bookDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            var bookDto = this.booksUseCase.GetBookDetail(id);
            var book = new BookEditViewModel { Id = bookDto.Id, ISBN = bookDto.ISBN, Name = bookDto.Name, Price = bookDto.Price };
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, BookEditViewModel viewModel)
        {
            try
            {
                var bookDto = new BookSaveDto
                {
                    Id = viewModel.Id,
                    AuthorId = viewModel.AuthorId,
                    ISBN = viewModel.ISBN,
                    Name = viewModel.Name,
                    Price = viewModel.Price
                };
                this.booksUseCase.Update(bookDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
