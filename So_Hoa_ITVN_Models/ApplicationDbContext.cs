namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        public virtual DbSet<S_Authority> S_Authority { get; set; }
        public virtual DbSet<S_DetailsVanBan> S_DetailsVanBan { get; set; }
        public virtual DbSet<S_DonViHanhChinh> S_DonViHanhChinh { get; set; }
        public virtual DbSet<S_File> S_File { get; set; }
        public virtual DbSet<S_FileAttachment> S_FileAttachment { get; set; }
        public virtual DbSet<S_HopSo> S_HopSo { get; set; }
        public virtual DbSet<S_HoSo> S_HoSo { get; set; }
        public virtual DbSet<S_Kho> S_Kho { get; set; }
        public virtual DbSet<S_LoaiVanBan> S_LoaiVanBan { get; set; }
        public virtual DbSet<S_LuuTru> S_LuuTru { get; set; }
        public virtual DbSet<S_Menu> S_Menu { get; set; }
        public virtual DbSet<S_MucLucHoSo> S_MucLucHoSo { get; set; }
        public virtual DbSet<S_NhanVien> S_NhanVien { get; set; }
        public virtual DbSet<S_Page> S_Page { get; set; }
        public virtual DbSet<S_Phong> S_Phong { get; set; }
        public virtual DbSet<S_Role> S_Role { get; set; }
        public virtual DbSet<S_Role_Uers_Atuthority_> S_Role_Uers_Atuthority_ { get; set; }
        public virtual DbSet<S_Users> S_Users { get; set; }
        public virtual DbSet<S_VanBan> S_VanBan { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<S_Authority>()
                .Property(e => e.AuthorityName)
                .IsFixedLength();

            modelBuilder.Entity<S_DonViHanhChinh>()
                .HasMany(e => e.S_Phong)
                .WithRequired(e => e.S_DonViHanhChinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<S_File>()
                .HasOptional(e => e.S_FileAttachment)
                .WithRequired(e => e.S_File);

            modelBuilder.Entity<S_FileAttachment>()
                .Property(e => e.URL)
                .IsFixedLength();

            modelBuilder.Entity<S_HopSo>()
                .HasMany(e => e.S_HoSo)
                .WithRequired(e => e.S_HopSo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<S_HoSo>()
                .HasMany(e => e.S_VanBan)
                .WithRequired(e => e.S_HoSo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<S_LoaiVanBan>()
                .Property(e => e.TenLoaiVanBan)
                .IsFixedLength();

            modelBuilder.Entity<S_LuuTru>()
                .HasMany(e => e.S_MucLucHoSo)
                .WithRequired(e => e.S_LuuTru)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<S_Menu>()
                .Property(e => e.MenuName)
                .IsFixedLength();

            modelBuilder.Entity<S_MucLucHoSo>()
                .HasMany(e => e.S_HopSo)
                .WithRequired(e => e.S_MucLucHoSo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<S_NhanVien>()
                .Property(e => e.User)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_NhanVien>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<S_NhanVien>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_Page>()
                .Property(e => e.PageName)
                .IsFixedLength();

            modelBuilder.Entity<S_Page>()
                .Property(e => e.URLPage)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_Role>()
                .Property(e => e.RoleName)
                .IsFixedLength();

            modelBuilder.Entity<S_Users>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<S_Users>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<S_Users>()
                .Property(e => e.PasswordSalt)
                .IsFixedLength();

            modelBuilder.Entity<S_VanBan>()
                .HasMany(e => e.S_File)
                .WithRequired(e => e.S_VanBan)
                .WillCascadeOnDelete(false);
        }
    }
}
