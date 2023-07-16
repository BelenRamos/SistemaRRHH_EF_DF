using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
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
        public virtual DbSet<EvalucionesPostulantes> EvalucionesPostulantes { get; set; }
        public virtual DbSet<OfertasLaborales> OfertasLaborales { get; set; }
        public virtual DbSet<OlClientes> OlClientes { get; set; }
        public virtual DbSet<OlConsultorAsignado> OlConsultorAsignado { get; set; }
        public virtual DbSet<OlEstados> OlEstados { get; set; }
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
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ClientesTelefonos>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.Telefono })
                    .HasName("PK__Clientes__35DE55618DDAB134");

                entity.ToTable("Clientes_Telefonos");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientesTelefonos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clientes___id_cl__398D8EEE");
            });

            modelBuilder.Entity<Consultores>(entity =>
            {
                entity.HasKey(e => e.Legajo)
                    .HasName("PK__Consulto__818C9F867ED8BD7F");

                entity.Property(e => e.Legajo)
                    .HasColumnName("legajo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Entrevistas>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK__Entrevis__FC77F210F54E6F83");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EntrevistasPerfiles>(entity =>
            {
                entity.HasKey(e => new { e.NroEntrevista, e.IdPerfil })
                    .HasName("PK__Entrevis__EC9F6DA3AAB56E47");

                entity.ToTable("Entrevistas_Perfiles");

                entity.Property(e => e.NroEntrevista).HasColumnName("nro_entrevista");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.EntrevistasPerfiles)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entrevist__id_pe__5070F446");

                entity.HasOne(d => d.NroEntrevistaNavigation)
                    .WithMany(p => p.EntrevistasPerfiles)
                    .HasForeignKey(d => d.NroEntrevista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entrevist__nro_e__4F7CD00D");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Estados__40F9A207A59B75D8");

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
                    .HasName("PK__Evaluaci__FC77F210873EAD9C");

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
                    .HasName("PK__Evaluaci__C4162C6B133656E0");

                entity.ToTable("Evaluaciones_Tipos");

                entity.Property(e => e.NroEvaluacion).HasColumnName("nro_evaluacion");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.EvaluacionesTipos)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evaluacio__id_ti__4AB81AF0");

                entity.HasOne(d => d.NroEvaluacionNavigation)
                    .WithMany(p => p.EvaluacionesTipos)
                    .HasForeignKey(d => d.NroEvaluacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evaluacio__nro_e__49C3F6B7");
            });

            modelBuilder.Entity<EvalucionesPostulantes>(entity =>
            {
                entity.HasKey(e => new { e.NroPostulante, e.NroEvaluacion })
                    .HasName("PK__Evalucio__EDAEFB41D10AC220");

                entity.ToTable("Evaluciones_Postulantes");

                entity.Property(e => e.NroPostulante).HasColumnName("nro_postulante");

                entity.Property(e => e.NroEvaluacion).HasColumnName("nro_evaluacion");

                entity.HasOne(d => d.NroEvaluacionNavigation)
                    .WithMany(p => p.EvalucionesPostulantes)
                    .HasForeignKey(d => d.NroEvaluacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evalucion__nro_e__76969D2E");

                entity.HasOne(d => d.NroPostulanteNavigation)
                    .WithMany(p => p.EvalucionesPostulantes)
                    .HasForeignKey(d => d.NroPostulante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evalucion__nro_p__75A278F5");
            });

            modelBuilder.Entity<OfertasLaborales>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK__Ofertas___FC77F210269588AD");

                entity.ToTable("Ofertas_Laborales");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(100);

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
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OlClientes>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.IdCliente })
                    .HasName("PK__OL_Clien__1487FDAD6B7713A1");

                entity.ToTable("OL_Clientes");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.OlClientes)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Client__id_cl__72C60C4A");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlClientes)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Client__nro_O__71D1E811");
            });

            modelBuilder.Entity<OlConsultorAsignado>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.LegajoConsultor })
                    .HasName("PK__OL_Consu__F1555F024800A5F7");

                entity.ToTable("OL_Consultor_Asignado");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.LegajoConsultor).HasColumnName("legajo_consultor");

                entity.HasOne(d => d.LegajoConsultorNavigation)
                    .WithMany(p => p.OlConsultorAsignado)
                    .HasForeignKey(d => d.LegajoConsultor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Consul__legaj__6EF57B66");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlConsultorAsignado)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Consul__nro_O__6E01572D");
            });

            modelBuilder.Entity<OlEstados>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.CodigoEstado })
                    .HasName("PK__OL_Estad__D4219B6035C58C22");

                entity.ToTable("OL_Estados");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.OlEstados)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Estado__codig__6B24EA82");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlEstados)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Estado__nro_O__6A30C649");
            });

            modelBuilder.Entity<OlPerfiles>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.IdPerfil })
                    .HasName("PK__OL_Perfi__C321C654FF07E9A2");

                entity.ToTable("OL_Perfiles");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.OlPerfiles)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Perfil__id_pe__6383C8BA");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlPerfiles)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Perfil__nro_O__628FA481");
            });

            modelBuilder.Entity<OlPostulantes>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.NroPostulante })
                    .HasName("PK__OL_Postu__3E620EBB3ABA31F0");

                entity.ToTable("OL_Postulantes");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.NroPostulante).HasColumnName("nro_postulante");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlPostulantes)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Postul__nro_O__66603565");

                entity.HasOne(d => d.NroPostulanteNavigation)
                    .WithMany(p => p.OlPostulantes)
                    .HasForeignKey(d => d.NroPostulante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Postul__nro_p__6754599E");
            });

            modelBuilder.Entity<OlRequisitos>(entity =>
            {
                entity.HasKey(e => new { e.NroOl, e.IdRequisito })
                    .HasName("PK__OL_Requi__C342FEB48D51FE32");

                entity.ToTable("OL_Requisitos");

                entity.Property(e => e.NroOl).HasColumnName("nro_OL");

                entity.Property(e => e.IdRequisito).HasColumnName("id_requisito");

                entity.HasOne(d => d.IdRequisitoNavigation)
                    .WithMany(p => p.OlRequisitos)
                    .HasForeignKey(d => d.IdRequisito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Requis__id_re__5FB337D6");

                entity.HasOne(d => d.NroOlNavigation)
                    .WithMany(p => p.OlRequisitos)
                    .HasForeignKey(d => d.NroOl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OL_Requis__nro_O__5EBF139D");
            });

            modelBuilder.Entity<Perfiles>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(300);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PerfilesPostulantes>(entity =>
            {
                entity.HasKey(e => new { e.NroPostulante, e.IdPerfil })
                    .HasName("PK__Perfiles__58F1C1E19A27298A");

                entity.ToTable("Perfiles_Postulantes");

                entity.Property(e => e.NroPostulante).HasColumnName("nro_postulante");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilesPostulantes)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Perfiles___id_pe__4316F928");

                entity.HasOne(d => d.NroPostulanteNavigation)
                    .WithMany(p => p.PerfilesPostulantes)
                    .HasForeignKey(d => d.NroPostulante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Perfiles___nro_p__4222D4EF");
            });

            modelBuilder.Entity<Postulantes>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK__Postulan__FC77F2105F913A2B");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50);

                entity.Property(e => e.EsCandidato).HasColumnName("esCandidato");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Psicologos>(entity =>
            {
                entity.HasKey(e => e.Matricula)
                    .HasName("PK__Psicolog__30962D142AAEBD97");

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
                    .HasMaxLength(100);
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
                    .HasName("PK__Turnos__38439DDAE17E8BFD");

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
                    .HasConstraintName("FK__Turnos__mat_psic__5629CD9C");

                entity.HasOne(d => d.NroEntrevistaNavigation)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.NroEntrevista)
                    .HasConstraintName("FK__Turnos__nro_entr__5535A963");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
