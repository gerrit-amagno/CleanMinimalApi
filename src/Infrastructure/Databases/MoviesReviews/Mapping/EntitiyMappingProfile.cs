namespace CleanMinimalApi.Infrastructure.Databases.MoviesReviews.Mapping;

using AutoMapper;
using Application = Application.Common.Entities;
using Infrastructure = Models;

public class EntitiyMappingProfile : Profile
{
    public EntitiyMappingProfile()
    {
        _ = this.CreateMap<Infrastructure.Entity, Application.Entity>().ReverseMap();
    }
}