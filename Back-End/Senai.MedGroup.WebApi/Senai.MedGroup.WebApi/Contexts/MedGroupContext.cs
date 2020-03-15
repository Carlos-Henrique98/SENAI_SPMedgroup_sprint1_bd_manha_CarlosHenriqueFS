using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class MedGroupContext : DbContext
    {
        public MedGroupContext()
        {
        }

        public MedGroupContext(DbContextOptions<MedGroupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TAdm> TAdm { get; set; }
        public virtual DbSet<TClinica> TClinica { get; set; }
        public virtual DbSet<TConsulta> TConsulta { get; set; }
        public virtual DbSet<TEspecialidade> TEspecialidade { get; set; }
        public virtual DbSet<TMedico> TMedico { get; set; }
        public virtual DbSet<TPaciente> TPaciente { get; set; }
        public virtual DbSet<TSituacao> TSituacao { get; set; }
        public virtual DbSet<TTipoUsuario> TTipoUsuario { get; set; }
        public virtual DbSet<TUsuario> TUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Data source=DESKTOP-GCOFA7F\\SQLEXPRESS; Initial Catalog=Gufi_Manha; user Id=sa; pwd=sa@132;");
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-N251D43S\\TEW_SQLEXPRESS; Initial Catalog=StoryTelling_Manha; integrated security = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAdm>(entity =>
            {
                entity.HasKey(e => e.IdAdm);

                entity.ToTable("T_ADM");

                entity.Property(e => e.IdAdm).HasColumnName("IdADM");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TAdm)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__T_ADM__IdUsuario__25A691D2");
            });

            modelBuilder.Entity<TClinica>(entity =>
            {
                entity.HasKey(e => e.IdClinica);

                entity.ToTable("T_Clinica");

                entity.HasIndex(e => e.Cnpj)
                    .HasName("UQ__T_Clinic__AA57D6B4741F7142")
                    .IsUnique();

                entity.HasIndex(e => e.Endereco)
                    .HasName("UQ__T_Clinic__4DF3E1FF0086C194")
                    .IsUnique();

                entity.HasIndex(e => e.NomeClinica)
                    .HasName("UQ__T_Clinic__5D092ACE2A46A3B7")
                    .IsUnique();

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomeClinica)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TConsulta>(entity =>
            {
                entity.HasKey(e => e.IdConsulta);

                entity.ToTable("T_Consulta");

                entity.Property(e => e.DataConsulta).HasColumnType("date");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.TConsulta)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK__T_Consult__IdMed__20E1DCB5");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.TConsulta)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK__T_Consult__IdPac__21D600EE");

                entity.HasOne(d => d.IdSituacaoNavigation)
                    .WithMany(p => p.TConsulta)
                    .HasForeignKey(d => d.IdSituacao)
                    .HasConstraintName("FK__T_Consult__IdSit__22CA2527");
            });

            modelBuilder.Entity<TEspecialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidade);

                entity.ToTable("T_Especialidade");

                entity.Property(e => e.NomeEspecialidade)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMedico>(entity =>
            {
                entity.HasKey(e => e.IdMedico);

                entity.ToTable("T_Medico");

                entity.Property(e => e.Crm)
                    .IsRequired()
                    .HasColumnName("CRM")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomeMedico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClinicaNavigation)
                    .WithMany(p => p.TMedico)
                    .HasForeignKey(d => d.IdClinica)
                    .HasConstraintName("FK__T_Medico__IdClin__147C05D0");

                entity.HasOne(d => d.IdEspecialidadeNavigation)
                    .WithMany(p => p.TMedico)
                    .HasForeignKey(d => d.IdEspecialidade)
                    .HasConstraintName("FK__T_Medico__IdEspe__15702A09");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TMedico)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__T_Medico__IdUsua__16644E42");
            });

            modelBuilder.Entity<TPaciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente);

                entity.ToTable("T_Paciente");

                entity.HasIndex(e => e.Cpf)
                    .HasName("UQ__T_Pacien__C1F89731F823E046")
                    .IsUnique();

                entity.HasIndex(e => e.NomePaciente)
                    .HasName("UQ__T_Pacien__C161D69D98D3F868")
                    .IsUnique();

                entity.HasIndex(e => e.Rg)
                    .HasName("UQ__T_Pacien__321537C86BADE1E0")
                    .IsUnique();

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GeneroP)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomePaciente)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("RG")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneP)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TPaciente)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__T_Pacient__IdUsu__1C1D2798");
            });

            modelBuilder.Entity<TSituacao>(entity =>
            {
                entity.HasKey(e => e.IdSituacao);

                entity.ToTable("T_Situacao");

                entity.Property(e => e.Situacao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.ToTable("T_TipoUsuario");

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("T_Usuario");

                entity.HasIndex(e => e.NomeUsuario)
                    .HasName("UQ__T_Usuari__06940B9A972CFB37")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NascimentoUsuario).HasColumnType("date");

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__T_Usuario__IdTip__119F9925");
            });
        }
    }
}
