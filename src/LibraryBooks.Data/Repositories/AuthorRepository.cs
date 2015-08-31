using LibraryBooks.Domain.Entities;
using LibraryBooks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repositories
{
    class AuthorRepository : IAuthorRepository
    {
        private List<AuthorEntity> authorList = new List<AuthorEntity>();

        public IEnumerable<AuthorEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public AuthorEntity FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(AuthorEntity authorEntity)
        {
            throw new NotImplementedException();
        }

        public void Update(AuthorEntity authorEntity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AuthorEntity authorEntity)
        {
            throw new NotImplementedException();
        }
    }
}
