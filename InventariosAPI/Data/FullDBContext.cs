using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using InventariosAPI.ModelsFull;

namespace InventariosAPI.Data
{
    public partial class FullDBContext : DbContext
    {
        public FullDBContext()
        {
        }

        public FullDBContext(DbContextOptions<FullDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adjflete> Adjflete { get; set; }
        public virtual DbSet<Adjtraslado> Adjtraslado { get; set; }
        public virtual DbSet<Almacenes> Almacenes { get; set; }
        public virtual DbSet<Arbolubicacion> Arbolubicacion { get; set; }
        public virtual DbSet<Arbolubicacionitems> Arbolubicacionitems { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Camiones> Camiones { get; set; }
        public virtual DbSet<CoCategoriaPrv> CoCategoriaPrv { get; set; }
        public virtual DbSet<CoProductosPrv> CoProductosPrv { get; set; }
        public virtual DbSet<CoProveedores> CoProveedores { get; set; }
        public virtual DbSet<CoProveedorescomprador> CoProveedorescomprador { get; set; }
        public virtual DbSet<CoProveedorescontacto> CoProveedorescontacto { get; set; }
        public virtual DbSet<CoSubcategoriaPrv> CoSubcategoriaPrv { get; set; }
        public virtual DbSet<Cp> Cp { get; set; }
        public virtual DbSet<Cveprodservcp> Cveprodservcp { get; set; }
        public virtual DbSet<Cveunidad> Cveunidad { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Flete> Flete { get; set; }
        public virtual DbSet<Folios> Folios { get; set; }
        public virtual DbSet<Foliosparametros> Foliosparametros { get; set; }
        public virtual DbSet<InCategoria> InCategoria { get; set; }
        public virtual DbSet<InInventario> InInventario { get; set; }
        public virtual DbSet<InKit> InKit { get; set; }
        public virtual DbSet<InKitcomponente> InKitcomponente { get; set; }
        public virtual DbSet<InLineaproducto> InLineaproducto { get; set; }
        public virtual DbSet<InMarca> InMarca { get; set; }
        public virtual DbSet<InMovimientos> InMovimientos { get; set; }
        public virtual DbSet<InProducto> InProducto { get; set; }
        public virtual DbSet<InSubcategoria> InSubcategoria { get; set; }
        public virtual DbSet<InTipoproducto> InTipoproducto { get; set; }
        public virtual DbSet<InUnidadEmpaque> InUnidadEmpaque { get; set; }
        public virtual DbSet<Materialpeligroso> Materialpeligroso { get; set; }
        public virtual DbSet<MtAsignaraplan> MtAsignaraplan { get; set; }
        public virtual DbSet<MtPlanes> MtPlanes { get; set; }
        public virtual DbSet<Negocios> Negocios { get; set; }
        public virtual DbSet<Operadores> Operadores { get; set; }
        public virtual DbSet<Origenmov> Origenmov { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<Parametrosentrada> Parametrosentrada { get; set; }
        public virtual DbSet<Tipotransporte> Tipotransporte { get; set; }
        public virtual DbSet<Tipotraslado> Tipotraslado { get; set; }
        public virtual DbSet<Tipoubicacion> Tipoubicacion { get; set; }
        public virtual DbSet<Transportista> Transportista { get; set; }
        public virtual DbSet<Traslado> Traslado { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<Ubicacionadj> Ubicacionadj { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }

        // Unable to generate entity type for table 'dbo.Hoja1$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Guanajuato'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ARDIGITAL\\SQL2017,2363; Database=IERP_Inventarios; User ID=Admin; Password=AdminSql753#; Trusted_Connection=False; MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Adjflete>(entity =>
            {
                entity.ToTable("ADJFLETE");

                entity.HasIndex(e => e.FleteId)
                    .HasName("IADJFLETE1");

                entity.Property(e => e.AdjFleteId)
                    .HasColumnName("AdjFleteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdjFlete1)
                    .IsRequired()
                    .HasColumnName("AdjFlete")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FleteId).HasColumnName("FleteID");

                entity.HasOne(d => d.Flete)
                    .WithMany(p => p.Adjflete)
                    .HasForeignKey(d => d.FleteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IADJFLETE1");
            });

            modelBuilder.Entity<Adjtraslado>(entity =>
            {
                entity.ToTable("ADJTRASLADO");

                entity.HasIndex(e => e.TrasladoId)
                    .HasName("IADJTRASLADO1");

                entity.Property(e => e.AdjTrasladoId)
                    .HasColumnName("AdjTrasladoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdjTraslado1)
                    .IsRequired()
                    .HasColumnName("AdjTraslado")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TrasladoId).HasColumnName("TrasladoID");

                entity.HasOne(d => d.Traslado)
                    .WithMany(p => p.Adjtraslado)
                    .HasForeignKey(d => d.TrasladoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IADJTRASLADO1");
            });

            modelBuilder.Entity<Almacenes>(entity =>
            {
                entity.HasKey(e => e.AlmacenId)
                    .HasName("PK__ALMACENE__022A08566ECB74B3");

                entity.ToTable("ALMACENES");

                entity.HasIndex(e => e.NegocioId)
                    .HasName("IALMACENES1");

                entity.Property(e => e.AlmacenId).HasColumnName("AlmacenID");

                entity.Property(e => e.AlmacenEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AlmacenNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AlmacenTag)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NegocioId).HasColumnName("NegocioID");

                entity.HasOne(d => d.Negocio)
                    .WithMany(p => p.Almacenes)
                    .HasForeignKey(d => d.NegocioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IALMACENES1");
            });

            modelBuilder.Entity<Arbolubicacion>(entity =>
            {
                entity.ToTable("ARBOLUBICACION");

                entity.Property(e => e.ArbolUbicacionId).HasColumnName("ArbolUbicacionID");

                entity.Property(e => e.ArbolUbicacionDescripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArbolUbicacionEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArbolUbicacionNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Arbolubicacionitems>(entity =>
            {
                entity.HasKey(e => e.ArbolUbicacionItemId)
                    .HasName("PK__ARBOLUBI__7A38E9FBEDA6A5D0");

                entity.ToTable("ARBOLUBICACIONITEMS");

                entity.HasIndex(e => e.ArbolUbicacionId)
                    .HasName("IARBOLUBICACIONITEMS3");

                entity.HasIndex(e => e.UbicacionId)
                    .HasName("IARBOLUBICACIONITEMS1");

                entity.HasIndex(e => e.UbicacionPadreId)
                    .HasName("IARBOLUBICACIONITEMS2");

                entity.Property(e => e.ArbolUbicacionItemId).HasColumnName("ArbolUbicacionItemID");

                entity.Property(e => e.ArbolUbicacionId).HasColumnName("ArbolUbicacionID");

                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.Property(e => e.UbicacionPadreId).HasColumnName("UbicacionPadreID");

                entity.HasOne(d => d.ArbolUbicacion)
                    .WithMany(p => p.Arbolubicacionitems)
                    .HasForeignKey(d => d.ArbolUbicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IARBOLUBICACIONITEMS3");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.ArbolubicacionitemsUbicacion)
                    .HasForeignKey(d => d.UbicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IARBOLUBICACIONITEMS1");

                entity.HasOne(d => d.UbicacionPadre)
                    .WithMany(p => p.ArbolubicacionitemsUbicacionPadre)
                    .HasForeignKey(d => d.UbicacionPadreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IARBOLUBICACIONITEMS2");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Camiones>(entity =>
            {
                entity.HasKey(e => e.CamionId)
                    .HasName("PK__CAMIONES__80E86F484BAD6B14");

                entity.ToTable("CAMIONES");

                entity.HasIndex(e => e.TipoTransporteId)
                    .HasName("ICAMIONES2");

                entity.HasIndex(e => e.TransportistaId)
                    .HasName("ICAMIONES1");

                entity.Property(e => e.CamionId).HasColumnName("CamionID");

                entity.Property(e => e.CamionDescripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CamionEconomico)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CamionEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CamionPlacas)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTransporteId).HasColumnName("TipoTransporteID");

                entity.Property(e => e.TransportistaId).HasColumnName("TransportistaID");

                entity.HasOne(d => d.TipoTransporte)
                    .WithMany(p => p.Camiones)
                    .HasForeignKey(d => d.TipoTransporteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICAMIONES2");

                entity.HasOne(d => d.Transportista)
                    .WithMany(p => p.Camiones)
                    .HasForeignKey(d => d.TransportistaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICAMIONES1");
            });

            modelBuilder.Entity<CoCategoriaPrv>(entity =>
            {
                entity.HasKey(e => e.CategoriaPrvId)
                    .HasName("PK__CO_CATEG__9A2744CE172F87EB");

                entity.ToTable("CO_CATEGORIA_PRV");

                entity.Property(e => e.CategoriaPrvId).HasColumnName("CategoriaPrvID");

                entity.Property(e => e.CategoriaPrvEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaPrvNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoProductosPrv>(entity =>
            {
                entity.HasKey(e => e.PrdPrvId)
                    .HasName("PK__CO_PRODU__8B1F3AE91F547937");

                entity.ToTable("CO_PRODUCTOS_PRV");

                entity.HasIndex(e => e.InProductoId)
                    .HasName("ICO_PRODUCTOS_PRV1");

                entity.HasIndex(e => e.ProveedorId)
                    .HasName("ICO_PRODUCTOS_PRV2");

                entity.Property(e => e.PrdPrvId).HasColumnName("PrdPrvID");

                entity.Property(e => e.InProductoId)
                    .IsRequired()
                    .HasColumnName("InProductoID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.HasOne(d => d.InProducto)
                    .WithMany(p => p.CoProductosPrv)
                    .HasForeignKey(d => d.InProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICO_PRODUCTOS_PRV1");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.CoProductosPrv)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICO_PRODUCTOS_PRV2");
            });

            modelBuilder.Entity<CoProveedores>(entity =>
            {
                entity.HasKey(e => e.ProveedorId)
                    .HasName("PK__CO_PROVE__61266BB9C1E53B12");

                entity.ToTable("CO_PROVEEDORES");

                entity.HasIndex(e => e.CColoniaId)
                    .HasName("ICO_PROVEEDORES3");

                entity.HasIndex(e => e.CLocalidadId)
                    .HasName("ICO_PROVEEDORES2");

                entity.HasIndex(e => e.CMunicipioId)
                    .HasName("ICO_PROVEEDORES4");

                entity.HasIndex(e => e.RegFisId)
                    .HasName("ICO_PROVEEDORES1");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.CColoniaId).HasColumnName("c_ColoniaID");

                entity.Property(e => e.CLocalidadId).HasColumnName("c_LocalidadID");

                entity.Property(e => e.CMunicipioId).HasColumnName("c_MunicipioID");

                entity.Property(e => e.ProveedorCalle)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorCp)
                    .IsRequired()
                    .HasColumnName("ProveedorCP")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorNoExt)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorNoInt)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorRazonSocial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorReferencia)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorRfc)
                    .IsRequired()
                    .HasColumnName("ProveedorRFC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorTag)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegFisId)
                    .IsRequired()
                    .HasColumnName("RegFisID")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoProveedorescomprador>(entity =>
            {
                entity.HasKey(e => new { e.ProveedorId, e.CocontactoId })
                    .HasName("PK__CO_PROVE__D887F71DB87171E1");

                entity.ToTable("CO_PROVEEDORESCOMPRADOR");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.CocontactoId).HasColumnName("COContactoID");

                entity.Property(e => e.CocontactoCelular)
                    .IsRequired()
                    .HasColumnName("COContactoCelular")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CocontactoEmail)
                    .IsRequired()
                    .HasColumnName("COContactoEmail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CocontactoExt)
                    .IsRequired()
                    .HasColumnName("COContactoExt")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CocontactoNombre)
                    .IsRequired()
                    .HasColumnName("COContactoNombre")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CocontactoPuesto)
                    .IsRequired()
                    .HasColumnName("COContactoPuesto")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CocontactoTelefono)
                    .IsRequired()
                    .HasColumnName("COContactoTelefono")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.CoProveedorescomprador)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICO_PROVEEDORESCOMPRADOR1");
            });

            modelBuilder.Entity<CoProveedorescontacto>(entity =>
            {
                entity.HasKey(e => new { e.ProveedorId, e.PrvContactoId })
                    .HasName("PK__CO_PROVE__128EBF1AB272682A");

                entity.ToTable("CO_PROVEEDORESCONTACTO");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.PrvContactoId).HasColumnName("PrvContactoID");

                entity.Property(e => e.PrvContactoCelular)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrvContactoEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrvContactoExt)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrvContactoNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrvContactoPuesto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrvContactoTelefono)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.CoProveedorescontacto)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICO_PROVEEDORESCONTACTO1");
            });

            modelBuilder.Entity<CoSubcategoriaPrv>(entity =>
            {
                entity.HasKey(e => e.SubCategoriaPrvId)
                    .HasName("PK__CO_SUBCA__34FC51390416228F");

                entity.ToTable("CO_SUBCATEGORIA_PRV");

                entity.HasIndex(e => e.CategoriaPrvId)
                    .HasName("ICO_SUBCATEGORIA_PRV1");

                entity.Property(e => e.SubCategoriaPrvId).HasColumnName("SubCategoriaPrvID");

                entity.Property(e => e.CategoriaPrvId).HasColumnName("CategoriaPrvID");

                entity.Property(e => e.SubCategoriaPrvEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubCategoriaPrvNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoriaPrv)
                    .WithMany(p => p.CoSubcategoriaPrv)
                    .HasForeignKey(d => d.CategoriaPrvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICO_SUBCATEGORIA_PRV1");
            });

            modelBuilder.Entity<Cp>(entity =>
            {
                entity.ToTable("CP");

                entity.Property(e => e.Cpid).HasColumnName("CPId");

                entity.Property(e => e.Cp1)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cpadmon)
                    .IsRequired()
                    .HasColumnName("CPAdmon")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cpasentamiento)
                    .IsRequired()
                    .HasColumnName("CPAsentamiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cpciudad)
                    .IsRequired()
                    .HasColumnName("CPCiudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cpentidad)
                    .IsRequired()
                    .HasColumnName("CPEntidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cpmunicipio)
                    .IsRequired()
                    .HasColumnName("CPMunicipio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CptipoAsentamiento)
                    .IsRequired()
                    .HasColumnName("CPTipoAsentamiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cpzona)
                    .IsRequired()
                    .HasColumnName("CPZona")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cveprodservcp>(entity =>
            {
                entity.ToTable("CVEPRODSERVCP");

                entity.Property(e => e.CveProdServCpid)
                    .HasColumnName("CveProdServCPID")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CveProdServDescripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CveProdServMaterialPeligro)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CveProdServPalabrasSimi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialPeligrosoId)
                    .HasColumnName("MaterialPeligrosoID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaterialPeligroso)
                    .WithMany(p => p.Cveprodservcp)
                    .HasForeignKey(d => d.MaterialPeligrosoId)
                    .HasConstraintName("ICVEPRODSERVCP1");
            });

            modelBuilder.Entity<Cveunidad>(entity =>
            {
                entity.HasKey(e => e.ClaveUnidadId)
                    .HasName("PK__CVEUNIDA__7CEED68FA6DD72F3");

                entity.ToTable("CVEUNIDAD");

                entity.Property(e => e.ClaveUnidadId)
                    .HasColumnName("ClaveUnidadID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveUnidadNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveUnidadTipo)
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.EmpresaId)
                    .HasName("PK__EMPRESAS__7B9F213665F42F9C");

                entity.ToTable("EMPRESAS");

                entity.Property(e => e.EmpresaId).HasColumnName("EmpresaID");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Flete>(entity =>
            {
                entity.ToTable("FLETE");

                entity.HasIndex(e => e.CamionId)
                    .HasName("IFLETE2");

                entity.HasIndex(e => e.CargoParaId)
                    .HasName("IFLETE5");

                entity.HasIndex(e => e.FolioId)
                    .HasName("IFLETE4");

                entity.HasIndex(e => e.OperadorId)
                    .HasName("IFLETE1");

                entity.Property(e => e.FleteId)
                    .HasColumnName("FleteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CamionId).HasColumnName("CamionID");

                entity.Property(e => e.CargoParaId).HasColumnName("CargoParaID");

                entity.Property(e => e.FleteCosto).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.FleteEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FleteFechaFin).HasColumnType("datetime");

                entity.Property(e => e.FleteFechaIni).HasColumnType("datetime");

                entity.Property(e => e.FleteFechaPrg).HasColumnType("datetime");

                entity.Property(e => e.FleteFechaReg).HasColumnType("datetime");

                entity.Property(e => e.FleteObserva)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FolioId).HasColumnName("FolioID");

                entity.Property(e => e.OperadorId).HasColumnName("OperadorID");

                entity.Property(e => e.SgUserId).HasColumnName("SgUserID");

                entity.HasOne(d => d.Camion)
                    .WithMany(p => p.Flete)
                    .HasForeignKey(d => d.CamionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFLETE2");

                entity.HasOne(d => d.CargoPara)
                    .WithMany(p => p.Flete)
                    .HasForeignKey(d => d.CargoParaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFLETE5");

                entity.HasOne(d => d.Folio)
                    .WithMany(p => p.Flete)
                    .HasForeignKey(d => d.FolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFLETE4");

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.Flete)
                    .HasForeignKey(d => d.OperadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFLETE1");
            });

            modelBuilder.Entity<Folios>(entity =>
            {
                entity.HasKey(e => e.FolioId)
                    .HasName("PK__FOLIOS__BC54E778232772EF");

                entity.ToTable("FOLIOS");

                entity.Property(e => e.FolioId).HasColumnName("FolioID");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FolioSerie)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Foliosparametros>(entity =>
            {
                entity.HasKey(e => e.FolioParametroId)
                    .HasName("PK__FOLIOSPA__7EDE6C77D1765669");

                entity.ToTable("FOLIOSPARAMETROS");

                entity.HasIndex(e => e.FolioId)
                    .HasName("IFOLIOSPARAMETROS2");

                entity.HasIndex(e => e.ParametroId)
                    .HasName("IFOLIOSPARAMETROS1");

                entity.Property(e => e.FolioParametroId).HasColumnName("FolioParametroID");

                entity.Property(e => e.FolioId).HasColumnName("FolioID");

                entity.Property(e => e.ParametroId).HasColumnName("ParametroID");

                entity.HasOne(d => d.Folio)
                    .WithMany(p => p.Foliosparametros)
                    .HasForeignKey(d => d.FolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFOLIOSPARAMETROS2");

                entity.HasOne(d => d.Parametro)
                    .WithMany(p => p.Foliosparametros)
                    .HasForeignKey(d => d.ParametroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFOLIOSPARAMETROS1");
            });

            modelBuilder.Entity<InCategoria>(entity =>
            {
                entity.ToTable("IN_CATEGORIA");

                entity.Property(e => e.InCategoriaId).HasColumnName("InCategoriaID");

                entity.Property(e => e.InCategoriaEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InCategorianombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InInventario>(entity =>
            {
                entity.ToTable("IN_INVENTARIO");

                entity.HasIndex(e => e.AlmacenId)
                    .HasName("IIN_INVENTARIO3");

                entity.HasIndex(e => e.InProductoId)
                    .HasName("IIN_INVENTARIO2");

                entity.HasIndex(e => e.UbicacionId)
                    .HasName("IIN_INVENTARIO1");

                entity.Property(e => e.InInventarioId).HasColumnName("InInventarioID");

                entity.Property(e => e.AlmacenId).HasColumnName("AlmacenID");

                entity.Property(e => e.InFisico).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.InInicial).HasColumnType("datetime");

                entity.Property(e => e.InLogico).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.InProductoCalibre)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoColor)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoId)
                    .IsRequired()
                    .HasColumnName("InProductoID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoLote)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoTalla)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.InInventario)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_INVENTARIO3");

                entity.HasOne(d => d.InProducto)
                    .WithMany(p => p.InInventario)
                    .HasForeignKey(d => d.InProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_INVENTARIO2");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.InInventario)
                    .HasForeignKey(d => d.UbicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_INVENTARIO1");
            });

            modelBuilder.Entity<InKit>(entity =>
            {
                entity.HasKey(e => e.KitId)
                    .HasName("PK__IN_KIT__C96EE747FBB246D6");

                entity.ToTable("IN_KIT");

                entity.HasIndex(e => e.InProductoId)
                    .HasName("IIN_KIT1");

                entity.Property(e => e.KitId).HasColumnName("KitID");

                entity.Property(e => e.InProductoId)
                    .IsRequired()
                    .HasColumnName("InProductoID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.KitEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.InProducto)
                    .WithMany(p => p.InKit)
                    .HasForeignKey(d => d.InProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_KIT1");
            });

            modelBuilder.Entity<InKitcomponente>(entity =>
            {
                entity.HasKey(e => new { e.KitId, e.ComponenteId })
                    .HasName("PK__IN_KITCO__3593FC7898603C33");

                entity.ToTable("IN_KITCOMPONENTE");

                entity.HasIndex(e => e.ComponenteId)
                    .HasName("IIN_KITCOMPONENTE1");

                entity.Property(e => e.KitId).HasColumnName("KitID");

                entity.Property(e => e.ComponenteId)
                    .HasColumnName("ComponenteID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ComponenteCantidad).HasColumnType("decimal(17, 2)");

                entity.HasOne(d => d.Componente)
                    .WithMany(p => p.InKitcomponente)
                    .HasForeignKey(d => d.ComponenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_KITCOMPONENTE1");

                entity.HasOne(d => d.Kit)
                    .WithMany(p => p.InKitcomponente)
                    .HasForeignKey(d => d.KitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_KITCOMPONENTE2");
            });

            modelBuilder.Entity<InLineaproducto>(entity =>
            {
                entity.HasKey(e => e.LineaProductoId)
                    .HasName("PK__IN_LINEA__A0B9DF91F747B294");

                entity.ToTable("IN_LINEAPRODUCTO");

                entity.HasIndex(e => e.CveProdServCpid)
                    .HasName("IIN_LINEAPRODUCTO1");

                entity.Property(e => e.LineaProductoId).HasColumnName("LineaProductoID");

                entity.Property(e => e.CveProdServCpid)
                    .IsRequired()
                    .HasColumnName("CveProdServCPID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LineaProductoNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CveProdServCp)
                    .WithMany(p => p.InLineaproducto)
                    .HasForeignKey(d => d.CveProdServCpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_LINEAPRODUCTO1");
            });

            modelBuilder.Entity<InMarca>(entity =>
            {
                entity.ToTable("IN_MARCA");

                entity.Property(e => e.InMarcaId).HasColumnName("InMarcaID");

                entity.Property(e => e.InMarcaEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InMarcaNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InMovimientos>(entity =>
            {
                entity.HasKey(e => e.InMovimientoId)
                    .HasName("PK__IN_MOVIM__4C878BCF5959621D");

                entity.ToTable("IN_MOVIMIENTOS");

                entity.HasIndex(e => e.AlmacenId)
                    .HasName("IIN_MOVIMIENTOS2");

                entity.HasIndex(e => e.InProductoId)
                    .HasName("IIN_MOVIMIENTOS3");

                entity.HasIndex(e => e.OrigenMovId)
                    .HasName("IIN_MOVIMIENTOS1");

                entity.Property(e => e.InMovimientoId).HasColumnName("InMovimientoID");

                entity.Property(e => e.AlmacenId).HasColumnName("AlmacenID");

                entity.Property(e => e.InMovimientoCalibre)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InMovimientoCantidad).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.InMovimientoColor)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InMovimientoFecDoc).HasColumnType("datetime");

                entity.Property(e => e.InMovimientoLote)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InMovimientoObs)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InMovimientoRegistro).HasColumnType("datetime");

                entity.Property(e => e.InMovimientoTalla)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InMovimientoTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoId)
                    .IsRequired()
                    .HasColumnName("InProductoID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenMovId).HasColumnName("OrigenMovID");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.InMovimientos)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_MOVIMIENTOS2");

                entity.HasOne(d => d.InProducto)
                    .WithMany(p => p.InMovimientos)
                    .HasForeignKey(d => d.InProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_MOVIMIENTOS3");

                entity.HasOne(d => d.OrigenMov)
                    .WithMany(p => p.InMovimientos)
                    .HasForeignKey(d => d.OrigenMovId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_MOVIMIENTOS1");
            });

            modelBuilder.Entity<InProducto>(entity =>
            {
                entity.ToTable("IN_PRODUCTO");

                entity.HasIndex(e => e.InMarcaId)
                    .HasName("IIN_PRODUCTO1");

                entity.HasIndex(e => e.InSubCategoriaId)
                    .HasName("IIN_PRODUCTO3");

                entity.HasIndex(e => e.InTipoProductoId)
                    .HasName("IIN_PRODUCTO2");

                entity.HasIndex(e => e.LineaProductoId)
                    .HasName("IIN_PRODUCTO5");

                entity.HasIndex(e => e.UnidadEmpaqueId)
                    .HasName("IIN_PRODUCTO4");

                entity.Property(e => e.InProductoId)
                    .HasColumnName("InProductoID")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.InMarcaId).HasColumnName("InMarcaID");

                entity.Property(e => e.InProductoAcalibre)
                    .IsRequired()
                    .HasColumnName("InProductoACalibre")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoAcolor)
                    .IsRequired()
                    .HasColumnName("InProductoAColor")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoAlote)
                    .IsRequired()
                    .HasColumnName("InProductoALote")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoAtalla)
                    .IsRequired()
                    .HasColumnName("InProductoATalla")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoDescripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoNombre)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoSerie)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InProductoTag)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InSubCategoriaId).HasColumnName("InSubCategoriaID");

                entity.Property(e => e.InTipoProductoId).HasColumnName("InTipoProductoID");

                entity.Property(e => e.LineaProductoId).HasColumnName("LineaProductoID");

                entity.Property(e => e.UnidadEmpaqueId).HasColumnName("UnidadEmpaqueID");

                entity.HasOne(d => d.InMarca)
                    .WithMany(p => p.InProducto)
                    .HasForeignKey(d => d.InMarcaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_PRODUCTO1");

                entity.HasOne(d => d.InSubCategoria)
                    .WithMany(p => p.InProducto)
                    .HasForeignKey(d => d.InSubCategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_PRODUCTO3");

                entity.HasOne(d => d.InTipoProducto)
                    .WithMany(p => p.InProducto)
                    .HasForeignKey(d => d.InTipoProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_PRODUCTO2");

                entity.HasOne(d => d.LineaProducto)
                    .WithMany(p => p.InProducto)
                    .HasForeignKey(d => d.LineaProductoId)
                    .HasConstraintName("IIN_PRODUCTO5");

                entity.HasOne(d => d.UnidadEmpaque)
                    .WithMany(p => p.InProducto)
                    .HasForeignKey(d => d.UnidadEmpaqueId)
                    .HasConstraintName("IIN_PRODUCTO4");
            });

            modelBuilder.Entity<InSubcategoria>(entity =>
            {
                entity.ToTable("IN_SUBCATEGORIA");

                entity.HasIndex(e => e.InCategoriaId)
                    .HasName("IIN_SUBCATEGORIA1");

                entity.Property(e => e.InSubCategoriaId).HasColumnName("InSubCategoriaID");

                entity.Property(e => e.InCategoriaId).HasColumnName("InCategoriaID");

                entity.Property(e => e.InSubCategoriaEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InSubCategoriaNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.InCategoria)
                    .WithMany(p => p.InSubcategoria)
                    .HasForeignKey(d => d.InCategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IIN_SUBCATEGORIA1");
            });

            modelBuilder.Entity<InTipoproducto>(entity =>
            {
                entity.ToTable("IN_TIPOPRODUCTO");

                entity.Property(e => e.InTipoProductoId).HasColumnName("InTipoProductoID");

                entity.Property(e => e.InTipoProductoEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InTipoProductoNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InUnidadEmpaque>(entity =>
            {
                entity.HasKey(e => e.UnidadEmpaqueId)
                    .HasName("PK__IN_UNIDA__3DE80866807FB038");

                entity.ToTable("IN_UNIDAD_EMPAQUE");

                entity.HasIndex(e => e.ClaveUnidadId)
                    .HasName("IIN_UNIDAD_EMPAQUE1");

                entity.Property(e => e.UnidadEmpaqueId).HasColumnName("UnidadEmpaqueID");

                entity.Property(e => e.ClaveUnidadId)
                    .HasColumnName("ClaveUnidadID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadEmpaqueEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadEmpaqueNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadEmpaqueTag)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClaveUnidad)
                    .WithMany(p => p.InUnidadEmpaque)
                    .HasForeignKey(d => d.ClaveUnidadId)
                    .HasConstraintName("IIN_UNIDAD_EMPAQUE1");
            });

            modelBuilder.Entity<Materialpeligroso>(entity =>
            {
                entity.ToTable("MATERIALPELIGROSO");

                entity.Property(e => e.MaterialPeligrosoId)
                    .HasColumnName("MaterialPeligrosoID")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaterialPeligrosoClase)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialPeligrosoDescripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialPeligrosoNombreTecnico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialPeligrosoSecundario)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MtAsignaraplan>(entity =>
            {
                entity.HasKey(e => new { e.MtplanId, e.EquipoId })
                    .HasName("PK__MT_ASIGN__2A026C95416F5C6A");

                entity.ToTable("MT_ASIGNARAPLAN");

                entity.Property(e => e.MtplanId).HasColumnName("MTPlanID");

                entity.Property(e => e.EquipoId)
                    .HasColumnName("EquipoID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MtsiguienteMantto)
                    .HasColumnName("MTSiguienteMantto")
                    .HasColumnType("datetime");

                entity.Property(e => e.MtultimaFecha)
                    .HasColumnName("MTUltimaFecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.MtultimoIndicador).HasColumnName("MTUltimoIndicador");

                entity.HasOne(d => d.Mtplan)
                    .WithMany(p => p.MtAsignaraplan)
                    .HasForeignKey(d => d.MtplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMT_ASIGNARAPLAN1");
            });

            modelBuilder.Entity<MtPlanes>(entity =>
            {
                entity.HasKey(e => e.MtplanId)
                    .HasName("PK__MT_PLANE__C7EACC2A63254FC0");

                entity.ToTable("MT_PLANES");

                entity.Property(e => e.MtplanId).HasColumnName("MTPlanID");

                entity.Property(e => e.MtplanEstatus)
                    .IsRequired()
                    .HasColumnName("MTPlanEstatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MtplanIndicador).HasColumnName("MTPlanIndicador");

                entity.Property(e => e.MtplanNombre)
                    .IsRequired()
                    .HasColumnName("MTPlanNombre")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MtplanPeriodo).HasColumnName("MTPlanPeriodo");
            });

            modelBuilder.Entity<Negocios>(entity =>
            {
                entity.HasKey(e => e.NegocioId)
                    .HasName("PK__NEGOCIOS__72945E4CB49D7C12");

                entity.ToTable("NEGOCIOS");

                entity.HasIndex(e => e.EmpresaId)
                    .HasName("INEGOCIOS1");

                entity.Property(e => e.NegocioId).HasColumnName("NegocioID");

                entity.Property(e => e.EmpresaId).HasColumnName("EmpresaID");

                entity.Property(e => e.NegocioEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NegocioNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Negocios)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("INEGOCIOS1");
            });

            modelBuilder.Entity<Operadores>(entity =>
            {
                entity.HasKey(e => e.OperadorId)
                    .HasName("PK__OPERADOR__43B6082E2850FF69");

                entity.ToTable("OPERADORES");

                entity.HasIndex(e => e.TransportistaId)
                    .HasName("IOPERADORES1");

                entity.Property(e => e.OperadorId).HasColumnName("OperadorID");

                entity.Property(e => e.OperadorApellidos)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OperadorEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OperadorNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OperadorTag)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaId).HasColumnName("TransportistaID");

                entity.HasOne(d => d.Transportista)
                    .WithMany(p => p.Operadores)
                    .HasForeignKey(d => d.TransportistaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IOPERADORES1");
            });

            modelBuilder.Entity<Origenmov>(entity =>
            {
                entity.ToTable("ORIGENMOV");

                entity.Property(e => e.OrigenMovId)
                    .HasColumnName("OrigenMovID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrigenMovEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenMovNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parametros>(entity =>
            {
                entity.HasKey(e => e.ParametroId)
                    .HasName("PK__PARAMETR__2B3CE67206B87F9C");

                entity.ToTable("PARAMETROS");

                entity.Property(e => e.ParametroId).HasColumnName("ParametroID");

                entity.Property(e => e.ParametroLista)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParametroNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ParametroQry)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parametrosentrada>(entity =>
            {
                entity.HasKey(e => e.ParametroEntradaId)
                    .HasName("PK__PARAMETR__925861F5A88EA230");

                entity.ToTable("PARAMETROSENTRADA");

                entity.HasIndex(e => e.FleteId)
                    .HasName("IPARAMETROSENTRADA1");

                entity.HasIndex(e => e.ParametroId)
                    .HasName("IPARAMETROSENTRADA2");

                entity.Property(e => e.ParametroEntradaId)
                    .HasColumnName("ParametroEntradaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FleteId).HasColumnName("FleteID");

                entity.Property(e => e.ParametroEntradaValor)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ParametroId).HasColumnName("ParametroID");

                entity.HasOne(d => d.Flete)
                    .WithMany(p => p.Parametrosentrada)
                    .HasForeignKey(d => d.FleteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPARAMETROSENTRADA1");

                entity.HasOne(d => d.Parametro)
                    .WithMany(p => p.Parametrosentrada)
                    .HasForeignKey(d => d.ParametroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPARAMETROSENTRADA2");
            });

            modelBuilder.Entity<Tipotransporte>(entity =>
            {
                entity.ToTable("TIPOTRANSPORTE");

                entity.Property(e => e.TipoTransporteId).HasColumnName("TipoTransporteID");

                entity.Property(e => e.TipoTransporteNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipotraslado>(entity =>
            {
                entity.ToTable("TIPOTRASLADO");

                entity.Property(e => e.TipoTrasladoId).HasColumnName("TipoTrasladoID");

                entity.Property(e => e.TipoTraslado1)
                    .IsRequired()
                    .HasColumnName("TipoTraslado")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTrasladoControlInv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipoubicacion>(entity =>
            {
                entity.HasKey(e => e.TipoUbicaId)
                    .HasName("PK__TIPOUBIC__FF8FAA84B687F3F4");

                entity.ToTable("TIPOUBICACION");

                entity.Property(e => e.TipoUbicaId).HasColumnName("TipoUbicaID");

                entity.Property(e => e.TipoUbica)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUbicaEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transportista>(entity =>
            {
                entity.ToTable("TRANSPORTISTA");

                entity.Property(e => e.TransportistaId).HasColumnName("TransportistaID");

                entity.Property(e => e.TransportistaEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TransportistaTag)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Traslado>(entity =>
            {
                entity.ToTable("TRASLADO");

                entity.HasIndex(e => e.FleteId)
                    .HasName("ITRASLADO4");

                entity.HasIndex(e => e.TipoTrasladoId)
                    .HasName("ITRASLADO1");

                entity.Property(e => e.TrasladoId)
                    .HasColumnName("TrasladoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DestinoId).HasColumnName("DestinoID");

                entity.Property(e => e.FleteId).HasColumnName("FleteID");

                entity.Property(e => e.OrigenId).HasColumnName("OrigenID");

                entity.Property(e => e.TipoTrasladoId).HasColumnName("TipoTrasladoID");

                entity.Property(e => e.TrasladoCanEnv).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.TrasladoCanRec).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.TrasladoDisEnv)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TrasladoDisRec)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TrasladoFechaEnv).HasColumnType("datetime");

                entity.Property(e => e.TrasladoFechaRec).HasColumnType("datetime");

                entity.Property(e => e.TrasladoGeoenv)
                    .IsRequired()
                    .HasColumnName("TrasladoGEOEnv")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrasladoGeorec)
                    .IsRequired()
                    .HasColumnName("TrasladoGEORec")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrasladoObjetoId)
                    .IsRequired()
                    .HasColumnName("TrasladoObjetoID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TrasladoObservacion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Destino)
                    .WithMany(p => p.TrasladoDestino)
                    .HasForeignKey(d => d.DestinoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ITRASLADO3");

                entity.HasOne(d => d.Flete)
                    .WithMany(p => p.Traslado)
                    .HasForeignKey(d => d.FleteId)
                    .HasConstraintName("ITRASLADO4");

                entity.HasOne(d => d.Origen)
                    .WithMany(p => p.TrasladoOrigen)
                    .HasForeignKey(d => d.OrigenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ITRASLADO2");

                entity.HasOne(d => d.TipoTraslado)
                    .WithMany(p => p.Traslado)
                    .HasForeignKey(d => d.TipoTrasladoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ITRASLADO1");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.ToTable("UBICACION");

                entity.HasIndex(e => e.Cpid)
                    .HasName("IUBICACION3");

                entity.HasIndex(e => e.TipoUbicaId)
                    .HasName("IUBICACION2");

                entity.HasIndex(e => e.ZonaId)
                    .HasName("IUBICACION1");

                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.Property(e => e.Cpid).HasColumnName("CPId");

                entity.Property(e => e.TipoUbicaId).HasColumnName("TipoUbicaID");

                entity.Property(e => e.Ubicacion1)
                    .IsRequired()
                    .HasColumnName("Ubicacion")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionGeo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaId).HasColumnName("ZonaID");

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.Ubicacion)
                    .HasForeignKey(d => d.Cpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUBICACION3");

                entity.HasOne(d => d.TipoUbica)
                    .WithMany(p => p.Ubicacion)
                    .HasForeignKey(d => d.TipoUbicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUBICACION2");

                entity.HasOne(d => d.Zona)
                    .WithMany(p => p.Ubicacion)
                    .HasForeignKey(d => d.ZonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUBICACION1");
            });

            modelBuilder.Entity<Ubicacionadj>(entity =>
            {
                entity.HasKey(e => new { e.UbicacionId, e.UbicacionAdjId })
                    .HasName("PK__UBICACIO__1020D63C182429E4");

                entity.ToTable("UBICACIONADJ");

                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.Property(e => e.UbicacionAdjId).HasColumnName("UbicacionAdjID");

                entity.Property(e => e.UbicacionAdjFile).IsRequired();

                entity.Property(e => e.UbicacionAdjFileGxi)
                    .IsRequired()
                    .HasColumnName("UbicacionAdjFile_GXI")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionAdjNombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.Ubicacionadj)
                    .HasForeignKey(d => d.UbicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUBICACIONADJ1");
            });

            modelBuilder.Entity<Zona>(entity =>
            {
                entity.ToTable("ZONA");

                entity.Property(e => e.ZonaId).HasColumnName("ZonaID");

                entity.Property(e => e.Zona1)
                    .IsRequired()
                    .HasColumnName("Zona")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaEstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });
        }
    }
}
