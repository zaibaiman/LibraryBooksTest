using LibraryBooks.Domain.UseCases;
using LibraryBooks.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryBooks.WebUI.Controllers
{
    public class AuthorsController : Controller
    {
        private IAuthorsUseCase authorsUseCase;

        public AuthorsController(IAuthorsUseCase authorsUseCase)
        {
            this.authorsUseCase = authorsUseCase;
        }

        // GET: Authors
        public ActionResult Index()
        {
            var authors = new List<AuthorViewModel>();
            foreach(var authorDto in this.authorsUseCase.GetAuthors()) {
                authors.Add(new AuthorViewModel 
                { 
                    Id = authorDto.Id, 
                    Name = authorDto.FirstName + " " + authorDto.LastName
                });
            }
            return View(authors);
        }

        // GET: Authors/Details/5
        public ActionResult Details(int id)
        {
            var authorDto = this.authorsUseCase.GetAuthorDetails(id);
            return View(new AuthorDetailViewModel 
            { 
                Id = authorDto.Id, 
                FirstName = authorDto.FirstName,
                LastName = authorDto.LastName,
                Email = authorDto.Email
            });
        }

        // GET: Authors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authors/Create
        [HttpPost]
        public ActionResult Create(AuthorDetailViewModel viewModel)
        {
            try
            {
                this.authorsUseCase.Create(new AuthorDto
                {
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Email = viewModel.Email
                });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Authors/Edit/5
        public ActionResult Edit(int id)
        {
            var authorDto = this.authorsUseCase.GetAuthorDetails(id);
            return View(new AuthorDetailViewModel 
            {
                Id = authorDto.Id,
                FirstName = authorDto.FirstName,
                LastName = authorDto.LastName,
                Email = authorDto.Email
            });
        }

        // POST: Authors/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AuthorDetailViewModel viewModel)
        {
            try
            {
                this.authorsUseCase.Update(new AuthorDto
                {
                    Id = viewModel.Id,
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Email = viewModel.Email
                });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Authors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authors/Delete/5
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
