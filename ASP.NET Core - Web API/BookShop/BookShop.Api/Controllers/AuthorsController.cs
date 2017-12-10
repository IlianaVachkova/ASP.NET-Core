using BookShop.Services;
using BookShop.Api.Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;

using static BookShop.Api.WebConstants;
using BookShop.Api.Models.Authors;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Get(int id) => this.OkOrNotFound(await this.authors.Details(id));

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AuthorRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = await this.authors.Create(model.FirstName, model.LatsName);

            return Ok(id);
        }
    }
}
