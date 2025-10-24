using GerenciaUsuario.Application.Interfaces;
using GerenciaUsuario.Application.DataObjects;
using Microsoft.AspNetCore.Mvc;

namespace GerenciaUsuario.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GerenciarUsuarioController : ControllerBase
{  
    private readonly IUsuarioService _usuarioService;
    private readonly ILogger<GerenciarUsuarioController> _logger;

    public GerenciarUsuarioController(IUsuarioService usuarioService, ILogger<GerenciarUsuarioController> logger)
    {        
        _logger = logger;
        _usuarioService = usuarioService;
    }

    [HttpPost]
    [ProducesResponseType(typeof(UsuarioRequest), StatusCodes.Status201Created)]
    public async Task<IActionResult> CriarUsuario([FromBody] UsuarioRequest request, CancellationToken token)
    {
        if (request == null)
            return BadRequest(StatusCode(400));
       
        var resultado = await _usuarioService.CriarUsuarioAsync(request, token);

        if (!resultado.Sucesso)
            return BadRequest(resultado.Erros);

        return CreatedAtAction(nameof(CriarUsuario), new { id = resultado.UsuarioId }, resultado);
    }
    
    [HttpGet("ConsultarUsuarioPorCPF")]
    public async Task<IActionResult> ConsultarUsuarioPorCPF([FromQuery] string cpf, CancellationToken token)
    {
        if (string.IsNullOrWhiteSpace(cpf))
            return BadRequest("CPF inválido.");
        
        var resultado = await _usuarioService.ConsultarUsuarioPorCPFAsync(cpf, token);

        return resultado != null ? Ok(resultado) : NotFound();
    }
}
