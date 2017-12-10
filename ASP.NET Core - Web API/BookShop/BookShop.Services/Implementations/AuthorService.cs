using AutoMapper.QueryableExtensions;
using BookShop.Services.Models.Authors;
using BookShop.Data;
using System.Linq;

namespace BookShop.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly BookShopDbContext db;

        public AuthorService(BookShopDbContext db)
        {
            this.db = db;
        }

        public AuthorDetailsServiceModel Details(int id)
            => this.db
            .Authors
            .Where(a => a.Id == id)
            .ProjectTo<AuthorDetailsServiceModel>()
            .FirstOrDefault();

    }
}
