using GerenciaUsuario.Domain.Interfaces;
using SharedKernel.Entities;

namespace GerenciaUsuario.Infrastructure.Persistence;

public class UsuarioRepository : IUsuarioRepository
{
    public readonly AppDbContext _context;
    
    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AdicionarUsuarioAsync(Usuario usuario)
    {
        await _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();
    }
}
