using AutoMapper;
using FoodApplication.Data;
using FoodApplication.Models.Items;
using FoodApplication.Models.Users;

namespace FoodApplication.Configuration;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<ApiUser, UserDto>().ReverseMap();
        CreateMap<ApiUser, AuthRegister>().ReverseMap();
        CreateMap<Item, ItemBase>().ReverseMap();
    }
}