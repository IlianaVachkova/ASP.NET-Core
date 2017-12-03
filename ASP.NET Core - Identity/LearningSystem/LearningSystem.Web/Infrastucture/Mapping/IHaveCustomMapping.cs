using AutoMapper;

namespace LearningSystem.Web.Infrastucture.Mapping
{
    public interface IHaveCustomMapping
    {
        void ConfigureMapping(Profile mapper);
    }
}
