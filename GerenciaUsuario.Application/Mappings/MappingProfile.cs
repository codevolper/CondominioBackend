using AutoMapper;
using SharedKernel.Entities;
using GerenciaUsuario.Application.DataObjects;

namespace GerenciaUsuario.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Usuario, UsuarioRequest>();
        CreateMap<Endereco, EnderecoRequest>();

        CreateMap<UsuarioRequest, Usuario>();
        CreateMap<EnderecoRequest, Endereco>();       
    }
}