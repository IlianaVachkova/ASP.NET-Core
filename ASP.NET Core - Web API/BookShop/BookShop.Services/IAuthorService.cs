using BookShop.Services.Models.Authors;

namespace BookShop.Services
{
    public interface IAuthorService
    {
        AuthorDetailsServiceModel Details(int id);

    }
}
