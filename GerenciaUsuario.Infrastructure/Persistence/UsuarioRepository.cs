using GerenciaUsuario.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedKernel.Entities;

namespace GerenciaUsuario.Infrastructure.Persistence;

public class UsuarioRepository : IUsuarioRepository
{
    public readonly AppDbContext _context;
    
    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> AdicionarUsuarioAsync(Usuario usuario, CancellationToken token)
    {
        await _context.Pessoa.AddAsync(usuario, token);
        return await _context.SaveChangesAsync();
    }

    public async Task<Usuario> ObterUsuarioPorCPF(string cpf, CancellationToken token)
    {
        return await _context.Pessoa.OfType<Usuario>()
            .Include(p => p.Endereco)
            .FirstOrDefaultAsync(p => p.CPF == cpf, token);
    }
}
