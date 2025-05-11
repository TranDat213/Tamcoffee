using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace TamCoffee.Models.Server
{
    public partial class TAMCOFFEEContext : DbContext
    {
        public TAMCOFFEEContext()
        {
        }

        public TAMCOFFEEContext(DbContextOptions<TAMCOFFEEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitiethoadon> Chitiethoadons { get; set; } = null!;
        public virtual DbSet<Chucvu> Chucvus { get; set; } = null!;
        public virtual DbSet<Donhang> Donhangs { get; set; } = null!;
        public virtual DbSet<Loaisanpham> Loaisanphams { get; set; } = null!;
        public virtual DbSet<Phuongthucthanhtoan> Phuongthucthanhtoans { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Taikhoan> Taikhoans { get; set; } = null!;
        public virtual DbSet<Trangthaidonhang> Trangthaidonhangs { get; set; } = null!;

        private static string connext_str = "server=localhost;port=3306;database=TAMCOFFEE;uid=root;password=;";
        private static ServerVersion version = ServerVersion.Parse("9.1.0-mysql");
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
                optionsBuilder.UseMySql(connext_str, version).UseLoggerFactory(loggerFactory);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.HasKey(e => new { e.MaSanPham, e.MaDonHang })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("chitiethoadon");

                entity.HasIndex(e => e.MaDonHang, "MaDonHang");

                entity.HasOne(d => d.MaDonHangNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.MaDonHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("chitiethoadon_ibfk_1");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("chitiethoadon_ibfk_2");
            });

            modelBuilder.Entity<Chucvu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PRIMARY");

                entity.ToTable("chucvu");

                entity.Property(e => e.TenChucVu).HasMaxLength(255);
            });

            modelBuilder.Entity<Donhang>(entity =>
            {
                entity.HasKey(e => e.MaDonHang)
                    .HasName("PRIMARY");

                entity.ToTable("donhang");

                entity.HasIndex(e => e.MaPttt, "MaPTTT");

                entity.HasIndex(e => e.MaTk, "MaTK");

                entity.HasIndex(e => e.MaTrangThaiDh, "MaTrangThaiDH");

                entity.Property(e => e.MaPttt).HasColumnName("MaPTTT");

                entity.Property(e => e.MaTk).HasColumnName("MaTK");

                entity.Property(e => e.MaTrangThaiDh).HasColumnName("MaTrangThaiDH");

                entity.Property(e => e.NgayLapHoaDon).HasColumnType("datetime");

                entity.HasOne(d => d.MaPtttNavigation)
                    .WithMany(p => p.Donhangs)
                    .HasForeignKey(d => d.MaPttt)
                    .HasConstraintName("DONHANG_ibfk_2");

                entity.HasOne(d => d.MaTkNavigation)
                    .WithMany(p => p.Donhangs)
                    .HasForeignKey(d => d.MaTk)
                    .HasConstraintName("DONHANG_ibfk_1");

                entity.HasOne(d => d.MaTrangThaiDhNavigation)
                    .WithMany(p => p.Donhangs)
                    .HasForeignKey(d => d.MaTrangThaiDh)
                    .HasConstraintName("DONHANG_ibfk_3");
            });

            modelBuilder.Entity<Loaisanpham>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSanPham)
                    .HasName("PRIMARY");

                entity.ToTable("loaisanpham");

                entity.Property(e => e.TenLoaiSanPham).HasMaxLength(255);
            });

            modelBuilder.Entity<Phuongthucthanhtoan>(entity =>
            {
                entity.HasKey(e => e.MaPttt)
                    .HasName("PRIMARY");

                entity.ToTable("phuongthucthanhtoan");

                entity.Property(e => e.MaPttt).HasColumnName("MaPTTT");

                entity.Property(e => e.TenPhuongThuc).HasMaxLength(100);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PRIMARY");

                entity.ToTable("sanpham");

                entity.HasIndex(e => e.MaLoaiSanPham, "MaLoaiSanPham");

                entity.Property(e => e.GiaSp)
                    .HasPrecision(10, 2)
                    .HasColumnName("GiaSP");

                entity.Property(e => e.TenSanPham).HasMaxLength(255);

                entity.HasOne(d => d.MaLoaiSanPhamNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.MaLoaiSanPham)
                    .HasConstraintName("sanpham_ibfk_1");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.MaTk)
                    .HasName("PRIMARY");

                entity.ToTable("taikhoan");

                entity.HasIndex(e => e.MaChucVu, "MaChucVu");

                entity.HasIndex(e => e.TenTaiKhoan, "TenTaiKhoan")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ_TAIKHOAN_Email")
                    .IsUnique();

                entity.Property(e => e.MaTk).HasColumnName("MaTK");

                entity.Property(e => e.HovaTen).HasMaxLength(255);

                entity.Property(e => e.MatKhau).HasMaxLength(255);

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.Taikhoans)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("TAIKHOAN_ibfk_1");
            });

            modelBuilder.Entity<Trangthaidonhang>(entity =>
            {
                entity.HasKey(e => e.MaTrangThaiDh)
                    .HasName("PRIMARY");

                entity.ToTable("trangthaidonhang");

                entity.Property(e => e.MaTrangThaiDh).HasColumnName("MaTrangThaiDH");

                entity.Property(e => e.TenTrangThai).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
