using GerenciaUsuario.API.Models;
using GerenciaUsuario.Application.Interfaces;
using GerenciaUsuario.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace GerenciaUsuario.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GerenciarUsuarioController : ControllerBase
{  
    private readonly ICriarUsuarioHandler _handler;
    private readonly ILogger<GerenciarUsuarioController> _logger;

    public GerenciarUsuarioController(ICriarUsuarioHandler hanlder, ILogger<GerenciarUsuarioController> logger)
    {
        _handler = hanlder;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioRequest request)
    {
        if (request == null)
            return BadRequest("Dados inválidos.");

        var command = new CriarUsuarioCommand
        {
            Nome = request.Nome,
            Email = request.Email,
            Senha = request.Senha,
            Telefone = request.Telefone,
            CPF = request.CPF,
            Perfil = request.Perfil
        };

        var resultado = await _handler.HandleAsync(command);

        if (!resultado.Sucesso)
            return BadRequest(resultado.Erros);

        return CreatedAtAction(nameof(CriarUsuario), new { id = resultado.UsuarioId }, resultado);
    }
}
