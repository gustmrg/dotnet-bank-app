using AutoMapper;
using MyBank.Business.Models;
using MyBank.Web.ViewModels;

namespace MyBank.Web.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Conta, ContaViewModel>().ReverseMap();
    }
}