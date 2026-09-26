using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vha2410900007_exam.Models;

public partial class VhaStudent2410900007DbContext : DbContext
{
    public VhaStudent2410900007DbContext()
    {
    }

    public VhaStudent2410900007DbContext(DbContextOptions<VhaStudent2410900007DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VhaStudent> VhaStudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=VhaStudent2410900007Db;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VhaStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VhaStude__3214EC0708A76DC7");

            entity.ToTable("VhaStudent");

            entity.Property(e => e.VhaActive).HasDefaultValue(true);
            entity.Property(e => e.VhaEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VhaName).HasMaxLength(100);
            entity.Property(e => e.VhaPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
