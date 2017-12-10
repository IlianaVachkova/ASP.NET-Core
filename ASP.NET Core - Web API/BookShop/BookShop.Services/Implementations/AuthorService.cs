using AutoMapper.QueryableExtensions;
using BookShop.Services.Models.Authors;
using BookShop.Data;
using System.Linq;
using BookShop.Data.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly BookShopDbContext db;

        public AuthorService(BookShopDbContext db)
        {
            this.db = db;
        }

        public async Task<int> Create(string firstName, string lastName)
        {
            var author = new Author
            {
                FirstName = firstName,
                LastName = lastName
            };

            this.db.Add(author);
            await this.db.SaveChangesAsync();

            return author.Id;
        }

        public async Task<AuthorDetailsServiceModel> Details(int id)
            => await this.db
            .Authors
            .Where(a => a.Id == id)
            .ProjectTo<AuthorDetailsServiceModel>()
            .FirstOrDefaultAsync();
    }
}
