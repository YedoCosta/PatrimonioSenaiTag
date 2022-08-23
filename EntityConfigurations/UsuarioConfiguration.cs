using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTag.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PatrimonioSenaiTag.EntityConfiguration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Nome)
               .IsRequired()
               .HasMaxLength(80);
        builder.Property(u => u.Sobrenome)
               .IsRequired()
               .HasMaxLength(80);
        builder.Property(u => u.Login)
               .IsRequired()
               .HasMaxLength(20);
        builder.Property(u => u.Senha)
               .IsRequired()
               .HasMaxLength(10);

          builder.HasOne(n => n.Nivel);
    }
}

