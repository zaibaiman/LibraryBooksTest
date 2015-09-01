using LibraryBooks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Domain.UseCases
{
    public class AuthorsUseCase : IAuthorsUseCase
    {
        private IAuthorRepository authorRepository;

        public AuthorsUseCase(IAuthorRepository authorRepository) {
            this.authorRepository = authorRepository;
        }

        public IEnumerable<AuthorDto> GetAuthors()
        {
            var result = new List<AuthorDto>();
            foreach (var authorEntity in authorRepository.FindAll())
            {
                result.Add(new AuthorDto 
                { 
                    Id = authorEntity.Id,
                    FirstName = authorEntity.FirstName,
                    LastName = authorEntity.LastName,
                    Email = authorEntity.Email
                });
            }
            return result;
        }

        public AuthorDto GetAuthorDetails(int id)
        {
            var authorEntity = this.authorRepository.FindById(id);
            return new AuthorDto
            {
                Id = authorEntity.Id,
                FirstName = authorEntity.FirstName,
                LastName = authorEntity.LastName,
                Email = authorEntity.Email
            };
        }

        public void Create(AuthorDto authorDto)
        {
            this.authorRepository.Create(new Entities.AuthorEntity
            {
                Id = authorDto.Id,
                FirstName = authorDto.FirstName,
                LastName = authorDto.LastName,
                Email = authorDto.Email
            });
        }

        public void Update(AuthorDto authorDto)
        {
            this.authorRepository.Create(new Entities.AuthorEntity
            {
                Id = authorDto.Id,
                FirstName = authorDto.FirstName,
                LastName = authorDto.LastName,
                Email = authorDto.Email
            });
        }

        public void Deleye(int id)
        {
            throw new NotImplementedException();
        }
    }
}
