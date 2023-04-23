﻿// <auto-generated />
using System;
using Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230423010216_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final_Project.Models.FavoriteFood", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("category");

                    b.Property<string>("CountryOfOrigin")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("country_of_origin");

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__Favorite__3213E83F78BE5829");

                    b.ToTable("FavoriteFood", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Mexican cuisine",
                            CountryOfOrigin = "Mexico",
                            Description = "A burrito is a type of food that consists of a large flour tortilla filled with various ingredients, such as rice, beans, meat, cheese, and vegetables.The filling is typically seasoned with spices and herbs to give it a distinctive flavor. urritos are often rolled up and served hot, either grilled or steamed, and can be eaten on their own or accompanied by salsa, guacamole, or sour cream.",
                            Name = "Burrito"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Chinese cuisine",
                            CountryOfOrigin = "China",
                            Description = "General Tso, also known as General Tso's chicken, is a popular Chinese  -American dish that consists of de  ep-fried chicken pieces that are coated in a sweet and savory sace. The sauce is made with soy sauce, hoisin sauce, vinegar, sugar, and chili peppers, giving it a complex flavor that is both spicy and tany. The dish is often served with steamed rice and vegetable.",
                            Name = "General Tso's"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Japanese cuisine",
                            CountryOfOrigin = "Japan",
                            Description = "Sushi is a type of Japanese dish that consists of vinegared rice combined with a variety of other ingredients, such as raw or cooked seafood, vegetables, and sometimes tropical fruits, wrapped in seaweed or served as   bite-sized ieces. The sushi is often served with soy sauce, wasabi, and pickled gnger. Sushi can be prepared in various forms, such as rolls (maki), ones (temaki), and   bite-sized ieces (nigri).",
                            Name = "Sushi"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Vietnamese cuisine",
                            CountryOfOrigin = "Vietnam",
                            Description = "Pho is a traditional Vietnamese noodle soup that consists of a savory broth, rice noodles, herbs, and meat, typically beef or chicken The broth is made by simmering bones, spices, and herbs for several hours to create a rich and flavorful base.The soup is then garnished with fresh herbs, such as cilantro and Thai basil, and served with lime wedges and bean sprouts. dditional spices and sauces, such as hoisin sauce and Sriracha, can also be added to customize the flavor.",
                            Name = "Pho"
                        });
                });

            modelBuilder.Entity("Final_Project.Models.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Difficulty")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("difficulty");

                    b.Property<string>("Name")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__Hobby__3213E83FDED86595");

                    b.ToTable("Hobby", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Learning",
                            Description = "Reading is the act of interpreting written or printed words to extract meaning or information. It involves using cognitive processes such as attention, perception, and comprehension to make sense of the text. Reading can be done for various purposes, including for entertainment, education, or research. It can involve reading books, articles, newspapers, or any other written material, and can be done in a variety of settings such as at home, in school, or in public spaces like libraries.",
                            Difficulty = "Medium",
                            Name = "Reading"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Exercise",
                            Description = "Biking, also known as cycling, is a mode of transportation or recreational activity that involves riding a bicycle, which is a two-wheeled vehicle powered by human pedaling. Biking can be done on various terrains, including roads, trails, and mountains, and can be enjoyed individually or in groups. Biking provides several health benefits, such as improved cardiovascular health, muscle strength, and flexibility, and is also an environmentally friendly mode of transportation.",
                            Difficulty = "Medium",
                            Name = "Biking"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Creative",
                            Description = "Cooking is the process of preparing food using various techniques and methods, such as heating, boiling, frying, baking, or grilling, to transform raw ingredients into edible dishes. Cooking involves combining different ingredients, such as meats, vegetables, spices, and herbs, to create flavorful and nutritious meals. It requires knowledge of cooking methods, culinary techniques, and food safety practices to ensure that food is cooked safely and properly. Cooking can be a creative and enjoyable activity that allows individuals to experiment with different flavors and ingredients and share meals with others. It is an essential life skill that provides numerous health benefits and can be enjoyed as a hobby or a profession.",
                            Difficulty = "Hard",
                            Name = "Cooking"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Adventure",
                            Description = "Traveling is the act of moving from one place to another, typically for leisure, business, or personal reasons. It involves visiting new destinations, experiencing different cultures, and engaging in activities that are unique to the place visited. Traveling can be done by various means, such as air, land, or sea, and can range from short trips to long-term stays in a particular location. It can be an enriching experience that broadens one's horizons, provides opportunities for personal growth, and creates lasting memories. Traveling can also have practical benefits, such as developing language skills, building new relationships, and gaining new perspectives on life.",
                            Difficulty = "Easy",
                            Name = "Traveling"
                        });
                });

            modelBuilder.Entity("Final_Project.Models.MemberInfo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime")
                        .HasColumnName("birthdate");

                    b.Property<string>("CollegeProgram")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("college_program");

                    b.Property<int?>("FavoriteFoodId")
                        .HasColumnType("int")
                        .HasColumnName("favorite_food_id");

                    b.Property<string>("FirstName")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("first_name");

                    b.Property<int?>("HobbyId")
                        .HasColumnType("int")
                        .HasColumnName("hobby_id");

                    b.Property<string>("LastName")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("last_name");

                    b.Property<int?>("PetId")
                        .HasColumnType("int")
                        .HasColumnName("pet_id");

                    b.Property<string>("Year")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("year");

                    b.HasKey("Id")
                        .HasName("PK__MemberIn__3213E83FDCEB11A7");

                    b.ToTable("MemberInfo", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(2002, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "IT",
                            FavoriteFoodId = 1,
                            FirstName = "Adam",
                            HobbyId = 1,
                            LastName = "Tulloss",
                            PetId = 1,
                            Year = "Sophmore"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(2001, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "IT",
                            FavoriteFoodId = 2,
                            FirstName = "Zach",
                            HobbyId = 2,
                            LastName = "Pittman",
                            PetId = 2,
                            Year = "Senior"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateTime(2003, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "IT",
                            FavoriteFoodId = 3,
                            FirstName = "Drew",
                            HobbyId = 3,
                            LastName = "Miluk",
                            PetId = 3,
                            Year = "Sophmore"
                        });
                });

            modelBuilder.Entity("Final_Project.Models.MemberPet", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Gender")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("name");

                    b.Property<string>("Type")
                        .HasMaxLength(16)
                        .IsUnicode(false)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("PK__MemberPe__3213E83F19ED9B2B");

                    b.ToTable("MemberPets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 5,
                            Gender = "Female",
                            Name = "Chrissy",
                            Type = "Dog"
                        },
                        new
                        {
                            Id = 2,
                            Age = 1,
                            Gender = "Male",
                            Name = "Noodle",
                            Type = "Snake"
                        },
                        new
                        {
                            Id = 3,
                            Age = 4,
                            Gender = "Female",
                            Name = "Coco",
                            Type = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
