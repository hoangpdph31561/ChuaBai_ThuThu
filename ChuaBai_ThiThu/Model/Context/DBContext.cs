using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ChuaBai_ThiThu.DomainClass;

namespace ChuaBai_ThiThu.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ban> Bans { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<LoaiSp> LoaiSps { get; set; } = null!;
        public virtual DbSet<LoaiXm> LoaiXms { get; set; } = null!;
        public virtual DbSet<MoiQuanHe> MoiQuanHes { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Nxb> Nxbs { get; set; } = null!;
        public virtual DbSet<Sach> Saches { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<XeMay> XeMays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=PHAMDUCHOANG\\SQLEXPRESS;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GioiTinh).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdMqhNavigation)
                    .WithMany(p => p.Bans)
                    .HasForeignKey(d => d.IdMqh)
                    .HasConstraintName("FK1_MQH");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<LoaiXm>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<MoiQuanHe>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCvNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCv)
                    .HasConstraintName("FK1_NV");
            });

            modelBuilder.Entity<Nxb>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoTrang).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdNxbNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.IdNxb)
                    .HasConstraintName("FK1_NXB");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdLoaiSpNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdLoaiSp)
                    .HasConstraintName("FK1_LSP");
            });

            modelBuilder.Entity<XeMay>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdLxmNavigation)
                    .WithMany(p => p.XeMays)
                    .HasForeignKey(d => d.IdLxm)
                    .HasConstraintName("FK1_LXM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
