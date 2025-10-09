using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using GerenciaUsuario.Infrastructure.Persistence;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CadastroUsuarios;User Id=sa;Password=C@ralhoFDP;TrustServerCertificate=True");

        return new AppDbContext(optionsBuilder.Options);
    }
}
