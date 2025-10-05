using Microsoft.EntityFrameworkCore;
using SharedKernel.Entities;

namespace GerenciaUsuario.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pessoa> Pessoa { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }    
    public DbSet<Endereco> Endereco { get; set; }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {      
        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
            entity.Property(e => e.CPF).IsRequired();
            entity.Property(e => e.Telefone).IsRequired();       
            
            entity.HasOne(p => p.Endereco)
                  .WithOne(e => e.Pessoa)
                  .HasForeignKey<Endereco>(e => e.PessoaId)
                  .OnDelete(DeleteBehavior.Cascade);
        });       

        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Logradouro).IsRequired();
            entity.Property(e => e.Cidade).IsRequired();
            entity.Property(e => e.Estado).IsRequired();
            entity.Property(e => e.Cep).IsRequired();

            entity.HasOne(e => e.Pessoa)
                  .WithOne(p => p.Endereco)
                  .HasForeignKey<Endereco>(e => e.PessoaId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        base.OnModelCreating(modelBuilder);
    }
}
