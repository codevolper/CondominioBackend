using AutoMapper;
using GerenciaUsuario.API.Models;
using GerenciaUsuario.Application.DataObjects;


namespace GerenciaUsuario.API.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UsuarioRequest, UsuarioDTO>();
        CreateMap<EnderecoRequest, EnderecoDTO>();
    }
}