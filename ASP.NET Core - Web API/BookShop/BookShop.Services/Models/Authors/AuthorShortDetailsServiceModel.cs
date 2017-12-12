using AutoMapper;
using BookShop.Common.Mapping;
using BookShop.Data.Models;

namespace BookShop.Services.Models.Authors
{
    public class AuthorShortDetailsServiceModel : IMapFrom<Author>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<Author, AuthorShortDetailsServiceModel>()
                .ForMember(am => am.Name, cfg => cfg.MapFrom(a => a.FirstName + " " + a.LastName));
        }
    }
}
