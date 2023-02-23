using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class WebBenhVienPTContext : DbContext
    {
        public WebBenhVienPTContext()
        {
        }

        public WebBenhVienPTContext(DbContextOptions<WebBenhVienPTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BenhAn> BenhAn { get; set; }
        public virtual DbSet<BenhNhan> BenhNhan { get; set; }
        public virtual DbSet<CaMo> CaMo { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhongMo> PhongMo { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<VaiTro> VaiTro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-VIEL6S6A\\THAILAI;Initial Catalog=WebBenhVienPT;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BenhAn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.Idbenh).HasColumnName("IDBenh");

                entity.Property(e => e.IdbenhNhan).HasColumnName("IDBenhNhan");

                entity.Property(e => e.MaBenhAn).HasMaxLength(50);

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.IdbenhNhanNavigation)
                    .WithMany(p => p.BenhAn)
                    .HasForeignKey(d => d.IdbenhNhan)
                    .HasConstraintName("FK_BenhAn_BenhNhan");
            });

            modelBuilder.Entity<BenhNhan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CanNang).HasMaxLength(50);

                entity.Property(e => e.ChieuCao).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.MaBn)
                    .HasColumnName("MaBN")
                    .HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(50);

                entity.Property(e => e.TenBn)
                    .HasColumnName("TenBN")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<CaMo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idbenh).HasColumnName("IDBenh");

                entity.Property(e => e.Idnv).HasColumnName("IDNV");

                entity.Property(e => e.MaCaMo).HasMaxLength(50);

                entity.Property(e => e.TenCaMo).HasMaxLength(50);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.IdtaiKhoan).HasColumnName("IDTaiKhoan");

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(50);

                entity.Property(e => e.TenNv)
                    .HasColumnName("TenNV")
                    .HasMaxLength(500);

                entity.HasOne(d => d.IdtaiKhoanNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.IdtaiKhoan)
                    .HasConstraintName("FK_NhanVien_TaiKhoan");
            });

            modelBuilder.Entity<PhongMo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idbenh).HasColumnName("IDBenh");

                entity.Property(e => e.IdcaMo)
                    .HasColumnName("IDCaMo")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaPhongMo).HasMaxLength(50);

                entity.Property(e => e.TenPhongMo).HasMaxLength(500);

                entity.Property(e => e.TrangThai).HasMaxLength(50);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdvaiTro).HasColumnName("IDVaiTro");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan1)
                    .HasColumnName("TaiKhoan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdvaiTroNavigation)
                    .WithMany(p => p.TaiKhoan)
                    .HasForeignKey(d => d.IdvaiTro)
                    .HasConstraintName("FK_TaiKhoan_VaiTro");
            });

            modelBuilder.Entity<VaiTro>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaVt)
                    .HasColumnName("MaVT")
                    .HasMaxLength(50);

                entity.Property(e => e.TenVaiTro).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
