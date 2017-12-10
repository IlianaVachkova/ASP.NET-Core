using BookShop.Services;
using BookShop.Api.Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;

using static BookShop.Api.WebConstants;

namespace BookShop.Api.Controllers
{
    public class AuthorsController : BaseController
    {
        public readonly IAuthorService authors;

        public AuthorsController(IAuthorService authors)
        {
            this.authors = authors;
        }

        [HttpGet(WithId)]
        public IActionResult Get(int id) => this.OkOrNotFound(this.authors.Details(id));
    }
}
