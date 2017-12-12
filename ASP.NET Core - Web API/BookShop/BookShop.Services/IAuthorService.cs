using BookShop.Services.Models.Authors;
using BookShop.Services.Models.Books;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookShop.Services
{
    public interface IAuthorService
    {
        Task<int> Create(string firstName, string lastName);

        Task<AuthorDetailsServiceModel> Details(int id);

        Task<bool> AuthorExists(int id);

        Task<IEnumerable<BookAllDetailsServiceModel>> GetAuthorBooks(int id);
    }
}
