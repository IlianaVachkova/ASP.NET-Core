using AutoMapper;

namespace BookShop.Api.Infrastructure.Mapping
{
    public interface IHaveCustomMapping
    {
        void ConfigureMapping(Profile mapper);
    }
}
