using AutoMapper.QueryableExtensions;
using BookShop.Services.Models.Authors;
using BookShop.Data;
using System.Linq;
using BookShop.Data.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShop.Services.Models.Books;
using System.Collections.Generic;

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

        public async Task<bool> AuthorExists(int id)
        {
            return this.db.Authors.Any(a => a.Id == id);
        }

        public async Task<IEnumerable<BookAllDetailsServiceModel>> GetAuthorBooks(int id)
        {
            return this.db.Books.Where(b => b.AuthorId == id).ProjectTo<BookAllDetailsServiceModel>().ToList();
        }
    }
}
