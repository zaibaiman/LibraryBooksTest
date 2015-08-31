using LibraryBooks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Domain.Repositories
{
    public interface IAuthorRepository
    {
        IEnumerable<AuthorEntity> FindAll();
        AuthorEntity FindById(int id);
        void Create(AuthorEntity authorEntity);
        void Update(AuthorEntity authorEntity);
        void Delete(AuthorEntity authorEntity);
    }
}
