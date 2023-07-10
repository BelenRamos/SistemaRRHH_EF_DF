using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo
{
    public partial class db_RRHHContext : DbContext
    {
        public db_RRHHContext()
        {
        }

        public db_RRHHContext(DbContextOptions<db_RRHHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ClientesTelefonos> ClientesTelefonos { get; set; }
        public virtual DbSet<Consultores> Consultores { get; set; }
        public virtual DbSet<Entrevistas> Entrevistas { get; set; }
        public virtual DbSet<EntrevistasPerfiles> EntrevistasPerfiles { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Evaluaciones> Evaluaciones { get; set; }
        public virtual DbSet<EvaluacionesTipos> EvaluacionesTipos { get; set; }
        public virtual DbSet<OfertasLaborales> OfertasLaborales { get; set; }
        public virtual DbSet<OlPerfiles> OlPerfiles { get; set; }
        public virtual DbSet<OlPostulantes> OlPostulantes { get; set; }
        public virtual DbSet<OlRequisitos> OlRequisitos { get; set; }
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<PerfilesPostulantes> PerfilesPostulantes { get; set; }
        public virtual DbSet<Postulantes> Postulantes { get; set; }
        public virtual DbSet<Psicologos> Psicologos { get; set; }
        public virtual DbSet<Requisitos> Requisitos { get; set; }
        public virtual DbSet<TipoEvaluaciones> TipoEvaluaciones { get; set; }
        public virtual DbSet<Turnos> Turnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost; Database= db_RRHH; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(30);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ClientesTelefonos>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.Telefono })
                    .HasName("PK__Clientes__35DE55614A3861B1");

                entity.ToTable("Clientes_Telefonos");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesTelefonos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clientes___id_cl__4BAC3F29");
            });

            modelBuilder.Entity<Consultores>(entity =>
            {
                entity.HasKey(e => e.Legajo)
                    .HasName("PK__Consulto__818C9F86569CBCB5");

                entity.Property(e => e.Legajo)
                    .HasColumnName("legajo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(20);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Entrevistas>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK__Entrevis__FC77F210E40A70DA");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<EntrevistasPerfiles>(entity =>
            {
                entity.HasKey(e => new { e.NroEntrevista, e.IdPerfil })
                    .HasName("PK__Entrevis__EC9F6DA346BE66E4");

                entity.ToTable("Entrevistas_Perfiles");

                entity.Property(e => e.NroEntrevista).HasColumnName("nro_entrevista");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.EntrevistasPerfiles)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entrevist__id_pe__628FA481");

                entity.HasOne(d => d.NroEntrevistaNavigation)
                    .WithMany(p => p.EntrevistasPerfiles)
                    .HasForeignKey(d => d.NroEntrevista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entrevist__nro_e__619B8048");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Estados__40F9A207E6FF55FB");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Designacion)
                    .HasColumnName("designacion")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Evaluaciones>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK__Evaluaci__FC77F21003209DCB");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(60);

                entity.Property(e => e.FechaEvaluacion)
                    .HasColumnName("fechaEvaluacion")
                    .HasColumnType("date");

                entity.Property(e => e.Profesional)
                    .HasColumnName("profesional")
                    .HasMaxLength(60);

                entity.Property(e => e.Resultado)
                    .HasColumnName("resultado")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<EvaluacionesTipos>(entity =>
            {
                entity.HasKey(e => new { e.NroEvaluacion, e.IdTipo })
                    .HasName("PK__Evaluaci__C4162C6BC83FC217");

                entity.ToTable("Evaluaciones_Tipos");

                entity.Property(e => e.NroEvaluacion).HasColumnName("nro_evaluacion");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.EvaluacionesTipos)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evaluacio__id_ti__5CD6CB2B");

                entity.HasOne(d => d.NroEvaluacionNavigation)
                    .WithMany(p => p.EvaluacionesTipos)
                    .HasForeignKey(d => d.NroEvaluacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evaluacio__nro_e__5BE2A6F2");
            });

            modelBuilder.Entity<OfertasLaborales>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK__Ofertas___FC77F21063731E47");

                entity.ToTable("Ofertas_Laborales");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(30);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(30);

                entity.Property(e => e.FechaCierre)
                    .HasColumnName("fechaCierre")
                    .HasColumnType("date");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPublicacion)
                    .HasColumnName("fechaPublicacion")
                    .HasColumnType("date");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<OlPerfiles>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.IdPerfil })
                    .HasName("PK__OL_Perfi__C321C65460334A8C");

                entity.ToTable("OL_Perfiles");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.OlPerfiles)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Perfil__id_pe__75A278F5");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlPerfiles)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Perfil__nro_O__74AE54BC");
            });

            modelBuilder.Entity<OlPostulantes>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.NroPostulante })
                    .HasName("PK__OL_Postu__3E620EBB51F4F432");

                entity.ToTable("OL_Postulantes");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.NroPostulante).HasColumnName("nro_postulante");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlPostulantes)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Postul__nro_O__787EE5A0");

                entity.HasOne(d => d.NroPostulanteNavigation)
                    .WithMany(p => p.OlPostulantes)
                    .HasForeignKey(d => d.NroPostulante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Postul__nro_p__797309D9");
            });

            modelBuilder.Entity<OlRequisitos>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.IdRequisito })
                    .HasName("PK__OL_Requi__C342FEB497C4B02F");

                entity.ToTable("OL_Requisitos");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.IdRequisito).HasColumnName("id_requisito");

                entity.HasOne(d => d.IdRequisitoNavigation)
                    .WithMany(p => p.OlRequisitos)
                    .HasForeignKey(d => d.IdRequisito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Requis__id_re__71D1E811");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlRequisitos)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Requis__nro_O__70DDC3D8");
            });

            modelBuilder.Entity<Perfiles>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(30);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PerfilesPostulantes>(entity =>
            {
                entity.HasKey(e => new { e.NroPostulante, e.IdPerfil })
                    .HasName("PK__Perfiles__58F1C1E1013A2BCC");

                entity.ToTable("Perfiles_Postulantes");

                entity.Property(e => e.NroPostulante).HasColumnName("nro_postulante");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilesPostulantes)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Perfiles___id_pe__5535A963");

                entity.HasOne(d => d.NroPostulanteNavigation)
                    .WithMany(p => p.PerfilesPostulantes)
                    .HasForeignKey(d => d.NroPostulante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Perfiles___nro_p__5441852A");
            });

            modelBuilder.Entity<Postulantes>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK__Postulan__FC77F210585B4CF2");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(20);

                entity.Property(e => e.EsCandidato).HasColumnName("esCandidato");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Psicologos>(entity =>
            {
                entity.HasKey(e => e.Matricula)
                    .HasName("PK__Psicolog__30962D140AE27177");

                entity.Property(e => e.Matricula)
                    .HasColumnName("matricula")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(30);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Requisitos>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TipoEvaluaciones>(entity =>
            {
                entity.ToTable("Tipo_Evaluaciones");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Detalle)
                    .HasColumnName("detalle")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Turnos>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.Horario, e.MatPsicologo })
                    .HasName("PK__Turnos__38439DDA323344B5");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Horario).HasColumnName("horario");

                entity.Property(e => e.MatPsicologo).HasColumnName("mat_psicologo");

                entity.Property(e => e.Disponible).HasColumnName("disponible");

                entity.Property(e => e.NroEntrevista).HasColumnName("nro_entrevista");

                entity.HasOne(d => d.MatPsicologoNavigation)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.MatPsicologo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Turnos__mat_psic__68487DD7");

                entity.HasOne(d => d.NroEntrevistaNavigation)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.NroEntrevista)
                    .HasConstraintName("FK__Turnos__nro_entr__6754599E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
