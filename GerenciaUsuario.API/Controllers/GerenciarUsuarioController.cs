using AutoMapper;
using GerenciaUsuario.API.Models;
using GerenciaUsuario.Application.DataObjects;
using GerenciaUsuario.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciaUsuario.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GerenciarUsuarioController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUsuarioService _usuarioService;
    private readonly ILogger<GerenciarUsuarioController> _logger;

    public GerenciarUsuarioController(IUsuarioService usuarioService, IMapper mapper, ILogger<GerenciarUsuarioController> logger)
    {   
        _usuarioService = usuarioService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> CriarUsuario([FromBody] UsuarioRequest request)
    {
        if (request == null)
            return BadRequest("Dados inválidos.");       

        // Aturalizar para estrutura de mapeamento.
        //var usuarioDTO = new Application.DataObjects.UsuarioDTO
        //{
        //    Nome = request.Nome,
        //    Email = request.Email,
        //    Senha = request.Senha,
        //    Telefone = request.Telefone,
        //    CPF = request.CPF,
        //    TipoUsuario = request.TipoUsuario,
        //    Endereco = new Application.DataObjects.EnderecoDTO
        //    {
        //        Logradouro = request.Endereco.Logradouro,
        //        Numero = request.Endereco.Numero,
        //        Complemento = request.Endereco.Complemento,
        //        Bairro = request.Endereco.Bairro,
        //        Cidade = request.Endereco.Cidade,
        //        Estado = request.Endereco.Estado,
        //        Cep = request.Endereco.Cep
        //    }
        //};

        var data = _mapper.Map<UsuarioDTO>(request);
        var resultado = await _usuarioService.CriarUsuarioAsync(data);

        if (!resultado.Sucesso)
            return BadRequest(resultado.Erros);

        return CreatedAtAction(nameof(CriarUsuario), new { id = resultado.UsuarioId }, resultado);
    }
}
