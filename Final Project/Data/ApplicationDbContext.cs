using System;
using System.Collections.Generic;
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FavoriteFood> FavoriteFoods { get; set; }

    public virtual DbSet<Hobby> Hobbies { get; set; }

    public virtual DbSet<MemberInfo> MemberInfos { get; set; }

    public virtual DbSet<MemberPet> MemberPets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=final;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FavoriteFood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Favorite__3213E83F78BE5829");

            entity.ToTable("FavoriteFood");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.CountryOfOrigin)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("country_of_origin");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Hobby>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hobby__3213E83FDED86595");

            entity.ToTable("Hobby");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Difficulty)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("difficulty");
            entity.Property(e => e.Name)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MemberInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MemberIn__3213E83FDCEB11A7");

            entity.ToTable("MemberInfo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.CollegeProgram)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("college_program");
            entity.Property(e => e.FavoriteFoodId).HasColumnName("favorite_food_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.HobbyId).HasColumnName("hobby_id");
            entity.Property(e => e.LastName)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.PetId).HasColumnName("pet_id");
            entity.Property(e => e.Year)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        modelBuilder.Entity<MemberPet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MemberPe__3213E83F19ED9B2B");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Gender)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
