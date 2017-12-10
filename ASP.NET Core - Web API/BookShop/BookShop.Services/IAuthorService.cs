using BookShop.Services.Models.Authors;
using System.Threading.Tasks;

namespace BookShop.Services
{
    public interface IAuthorService
    {
        Task<int> Create(string firstName, string lastName);

        Task<AuthorDetailsServiceModel> Details(int id);
    }
}
