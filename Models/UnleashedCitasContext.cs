using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UnleashedTechAgenda.Models
{
    public partial class UnleashedCitasContext : DbContext
    {
        public UnleashedCitasContext()
        {
        }

        public UnleashedCitasContext(DbContextOptions<UnleashedCitasContext> options)
            : base(options)
        {
        }

        public static object Usuario { get; internal set; }
        public virtual DbSet<Cita> Cita { get; set; } = null!;
        public virtual DbSet<Especialista> Especialista { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TBCIP73\\SQLEXPRESS;Database=UnleashedCitas;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Fin).HasColumnType("datetime");

                entity.Property(e => e.Idespecialista).HasColumnName("IDEspecialista");

                entity.Property(e => e.Idservicio).HasColumnName("IDServicio");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.HasOne(d => d.CedulaUsuarioNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.CedulaUsuario)
                    .HasConstraintName("FK__Cita__CedulaUsua__4CA06362");

                entity.HasOne(d => d.IdespecialistaNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.Idespecialista)
                    .HasConstraintName("FK__Cita__IDEspecial__4D94879B");

                entity.HasOne(d => d.IdservicioNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.Idservicio)
                    .HasConstraintName("FK__Cita__IDServicio__4E88ABD4");
            });

            modelBuilder.Entity<Especialista>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.ToTable("Servicio");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NombreServicio)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PK__Usuario__B4ADFE392029BD2C");

                entity.ToTable("Usuario");

                entity.Property(e => e.Cedula).ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
