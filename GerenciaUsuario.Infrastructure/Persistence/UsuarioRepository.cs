using GerenciaUsuario.Application.Interfaces;
using SharedKernel.Entities;

namespace GerenciaUsuario.Infrastructure.Persistence;

public class UsuarioRepository : IUsuarioRepository
{
    public readonly AppDbContext _context;
    
    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> AdicionarUsuarioAsync(Usuario usuario)
    {
        await _context.Pessoa.AddAsync(usuario);
        return await _context.SaveChangesAsync();
    }
}
