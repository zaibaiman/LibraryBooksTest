using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Domain.UseCases
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public interface IAuthorsUseCase
    {
        IEnumerable<AuthorDto> GetAuthors();
        AuthorDto GetAuthorDetails(int id);
        void Create(AuthorDto authorDto);
        void Update(AuthorDto authorDto);
        void Deleye(int id);
    }
}
