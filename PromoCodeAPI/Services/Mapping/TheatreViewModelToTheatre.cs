using AutoMapper;
using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.ViewModels;

namespace PromoCodeAPI.Services.Mapping
{
    public class TheatreViewModelToTheatre : Profile
    {
        public TheatreViewModelToTheatre()
        {
            CreateMap<TheatreViewModel, Theatre>();
        }
    }
}
