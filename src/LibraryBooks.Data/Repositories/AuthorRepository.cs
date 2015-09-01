using LibraryBooks.Domain.Entities;
using LibraryBooks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private List<AuthorEntity> authorList = new List<AuthorEntity>();

        public AuthorRepository()
        {
            authorList.Add(new AuthorEntity { Id = 0, FirstName = "Frank", LastName = "Mendoza", Email = "zaibaiman@hotmail.com" });
        }

        public IEnumerable<AuthorEntity> FindAll()
        {
            List<AuthorEntity> newList = new List<AuthorEntity>();
            foreach (var entity in authorList)
            {
                newList.Add(Clone(entity));
            }
            return newList;
        }

        public AuthorEntity FindById(int id)
        {
            foreach (var entity in authorList)
            {
                if (entity.Id == id) return entity;
            }
            return null;
        }

        public void Create(AuthorEntity authorEntity)
        {
            var newEntity = Clone(authorEntity);
            newEntity.Id = authorList.Count;
            authorList.Add(newEntity);
        }

        public void Update(AuthorEntity authorEntity)
        {
            var savedEntity = FindById(authorEntity.Id);
            savedEntity.Id = authorEntity.Id;
            savedEntity.FirstName = authorEntity.FirstName;
            savedEntity.LastName = authorEntity.LastName;
            savedEntity.Email = authorEntity.Email;
        }

        public void Delete(AuthorEntity authorEntity)
        {
            throw new NotImplementedException();
        }

        private AuthorEntity Clone(AuthorEntity authorEntity)
        {
            return new AuthorEntity
            {
                Id = authorEntity.Id,
                FirstName = authorEntity.FirstName,
                LastName = authorEntity.LastName,
                Email = authorEntity.Email
            };
        }
    }
}
