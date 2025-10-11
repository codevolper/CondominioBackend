using AutoMapper;
using SharedKernel.Entities;
using GerenciaUsuario.Application.DataObjects;

namespace GerenciaUsuario.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UsuarioRequest, Usuario>();
        CreateMap<EnderecoRequest, Endereco>();
    }
}