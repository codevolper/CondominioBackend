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
        _mapper = mapper;
        _logger = logger;
        _usuarioService = usuarioService;
    }

    [HttpPost]
    [ProducesResponseType(typeof(UsuarioRequest), StatusCodes.Status201Created)]
    public async Task<IActionResult> CriarUsuario([FromBody] UsuarioRequest request)
    {
        if (request == null)
            return BadRequest(StatusCode(400));

        var data = _mapper.Map<UsuarioDTO>(request);
        var resultado = await _usuarioService.CriarUsuarioAsync(data);

        if (!resultado.Sucesso)
            return BadRequest(resultado.Erros);

        return CreatedAtAction(nameof(CriarUsuario), new { id = resultado.UsuarioId }, resultado);
    }
}
