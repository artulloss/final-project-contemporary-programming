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
        => optionsBuilder.UseSqlServer();

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
            entity.HasData(
                new FavoriteFood { Id = 1, Name = "Burrito", Category = "Mexican cuisine", Description = "A burrito is a type of food that consists of a large flour tortilla filled with various ingredients, such as rice, beans, meat, cheese, and vegetables.The filling is typically seasoned with spices and herbs to give it a distinctive flavor. urritos are often rolled up and served hot, either grilled or steamed, and can be eaten on their own or accompanied by salsa, guacamole, or sour cream.", CountryOfOrigin = "Mexico" },
                new FavoriteFood { Id = 2, Name = "General Tso's", Category = "Chinese cuisine", Description = "General Tso, also known as General Tso's chicken, is a popular Chinese  -American dish that consists of de  ep-fried chicken pieces that are coated in a sweet and savory sace. The sauce is made with soy sauce, hoisin sauce, vinegar, sugar, and chili peppers, giving it a complex flavor that is both spicy and tany. The dish is often served with steamed rice and vegetable.", CountryOfOrigin = "China" },
                new FavoriteFood { Id = 3, Name = "Sushi", Category = "Japanese cuisine", Description = "Sushi is a type of Japanese dish that consists of vinegared rice combined with a variety of other ingredients, such as raw or cooked seafood, vegetables, and sometimes tropical fruits, wrapped in seaweed or served as   bite-sized ieces. The sushi is often served with soy sauce, wasabi, and pickled gnger. Sushi can be prepared in various forms, such as rolls (maki), ones (temaki), and   bite-sized ieces (nigri).", CountryOfOrigin = "Japan" },
                new FavoriteFood { Id = 4, Name = "Pho", Category = "Vietnamese cuisine", Description = "Pho is a traditional Vietnamese noodle soup that consists of a savory broth, rice noodles, herbs, and meat, typically beef or chicken The broth is made by simmering bones, spices, and herbs for several hours to create a rich and flavorful base.The soup is then garnished with fresh herbs, such as cilantro and Thai basil, and served with lime wedges and bean sprouts. dditional spices and sauces, such as hoisin sauce and Sriracha, can also be added to customize the flavor.", CountryOfOrigin = "Vietnam" }
            );
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
            entity.HasData(
                new Hobby { Id = 1, Name = "Reading", Category = "Learning", Description = "Reading is the act of interpreting written or printed words to extract meaning or information. It involves using cognitive processes such as attention, perception, and comprehension to make sense of the text. Reading can be done for various purposes, including for entertainment, education, or research. It can involve reading books, articles, newspapers, or any other written material, and can be done in a variety of settings such as at home, in school, or in public spaces like libraries.", Difficulty = "Medium" },
                new Hobby { Id = 2, Name = "Biking", Category = "Exercise", Description = "Biking, also known as cycling, is a mode of transportation or recreational activity that involves riding a bicycle, which is a two-wheeled vehicle powered by human pedaling. Biking can be done on various terrains, including roads, trails, and mountains, and can be enjoyed individually or in groups. Biking provides several health benefits, such as improved cardiovascular health, muscle strength, and flexibility, and is also an environmentally friendly mode of transportation.", Difficulty = "Medium" },
                new Hobby { Id = 3, Name = "Cooking", Category = "Creative", Description = "Cooking is the process of preparing food using various techniques and methods, such as heating, boiling, frying, baking, or grilling, to transform raw ingredients into edible dishes. Cooking involves combining different ingredients, such as meats, vegetables, spices, and herbs, to create flavorful and nutritious meals. It requires knowledge of cooking methods, culinary techniques, and food safety practices to ensure that food is cooked safely and properly. Cooking can be a creative and enjoyable activity that allows individuals to experiment with different flavors and ingredients and share meals with others. It is an essential life skill that provides numerous health benefits and can be enjoyed as a hobby or a profession.", Difficulty = "Hard" },
                new Hobby { Id = 4, Name = "Traveling", Category = "Adventure", Description = "Traveling is the act of moving from one place to another, typically for leisure, business, or personal reasons. It involves visiting new destinations, experiencing different cultures, and engaging in activities that are unique to the place visited. Traveling can be done by various means, such as air, land, or sea, and can range from short trips to long-term stays in a particular location. It can be an enriching experience that broadens one's horizons, provides opportunities for personal growth, and creates lasting memories. Traveling can also have practical benefits, such as developing language skills, building new relationships, and gaining new perspectives on life.", Difficulty = "Easy" }
            );
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
            entity.HasData(
                new MemberInfo { Id = 1, FirstName = "Adam", LastName = "Tulloss", Birthdate = new DateTime(2002, 07, 01), CollegeProgram = "IT", Year = "Sophmore", HobbyId = 1, PetId = 1, FavoriteFoodId = 1 },
                new MemberInfo { Id = 2, FirstName = "Zach", LastName = "Pittman", Birthdate = new DateTime(2001, 06, 21), CollegeProgram = "IT", Year = "Senior", HobbyId = 2, PetId = 2, FavoriteFoodId = 2 },
                new MemberInfo { Id = 3, FirstName = "Drew", LastName = "Miluk", Birthdate = new DateTime(2003, 03, 07), CollegeProgram = "IT", Year = "Sophmore", HobbyId = 3, PetId = 3, FavoriteFoodId = 3 }
            );
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
            entity.HasData(
                new MemberPet { Id = 1, Name = "Chrissy", Type = "Dog", Gender = "Female", Age = 5 },
                new MemberPet { Id = 2, Name = "Noodle", Type = "Snake", Gender = "Male", Age = 1 },
                new MemberPet { Id = 3, Name = "Coco", Type = "Dog", Gender = "Female", Age = 4 }
            );
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
