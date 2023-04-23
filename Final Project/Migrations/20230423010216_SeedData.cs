using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FavoriteFood",
                columns: new[] { "id", "category", "country_of_origin", "description", "name" },
                values: new object[,]
                {
                    { 1, "Mexican cuisine", "Mexico", "A burrito is a type of food that consists of a large flour tortilla filled with various ingredients, such as rice, beans, meat, cheese, and vegetables.The filling is typically seasoned with spices and herbs to give it a distinctive flavor. urritos are often rolled up and served hot, either grilled or steamed, and can be eaten on their own or accompanied by salsa, guacamole, or sour cream.", "Burrito" },
                    { 2, "Chinese cuisine", "China", "General Tso, also known as General Tso's chicken, is a popular Chinese  -American dish that consists of de  ep-fried chicken pieces that are coated in a sweet and savory sace. The sauce is made with soy sauce, hoisin sauce, vinegar, sugar, and chili peppers, giving it a complex flavor that is both spicy and tany. The dish is often served with steamed rice and vegetable.", "General Tso's" },
                    { 3, "Japanese cuisine", "Japan", "Sushi is a type of Japanese dish that consists of vinegared rice combined with a variety of other ingredients, such as raw or cooked seafood, vegetables, and sometimes tropical fruits, wrapped in seaweed or served as   bite-sized ieces. The sushi is often served with soy sauce, wasabi, and pickled gnger. Sushi can be prepared in various forms, such as rolls (maki), ones (temaki), and   bite-sized ieces (nigri).", "Sushi" },
                    { 4, "Vietnamese cuisine", "Vietnam", "Pho is a traditional Vietnamese noodle soup that consists of a savory broth, rice noodles, herbs, and meat, typically beef or chicken The broth is made by simmering bones, spices, and herbs for several hours to create a rich and flavorful base.The soup is then garnished with fresh herbs, such as cilantro and Thai basil, and served with lime wedges and bean sprouts. dditional spices and sauces, such as hoisin sauce and Sriracha, can also be added to customize the flavor.", "Pho" }
                });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "id", "category", "description", "difficulty", "name" },
                values: new object[,]
                {
                    { 1, "Learning", "Reading is the act of interpreting written or printed words to extract meaning or information. It involves using cognitive processes such as attention, perception, and comprehension to make sense of the text. Reading can be done for various purposes, including for entertainment, education, or research. It can involve reading books, articles, newspapers, or any other written material, and can be done in a variety of settings such as at home, in school, or in public spaces like libraries.", "Medium", "Reading" },
                    { 2, "Exercise", "Biking, also known as cycling, is a mode of transportation or recreational activity that involves riding a bicycle, which is a two-wheeled vehicle powered by human pedaling. Biking can be done on various terrains, including roads, trails, and mountains, and can be enjoyed individually or in groups. Biking provides several health benefits, such as improved cardiovascular health, muscle strength, and flexibility, and is also an environmentally friendly mode of transportation.", "Medium", "Biking" },
                    { 3, "Creative", "Cooking is the process of preparing food using various techniques and methods, such as heating, boiling, frying, baking, or grilling, to transform raw ingredients into edible dishes. Cooking involves combining different ingredients, such as meats, vegetables, spices, and herbs, to create flavorful and nutritious meals. It requires knowledge of cooking methods, culinary techniques, and food safety practices to ensure that food is cooked safely and properly. Cooking can be a creative and enjoyable activity that allows individuals to experiment with different flavors and ingredients and share meals with others. It is an essential life skill that provides numerous health benefits and can be enjoyed as a hobby or a profession.", "Hard", "Cooking" },
                    { 4, "Adventure", "Traveling is the act of moving from one place to another, typically for leisure, business, or personal reasons. It involves visiting new destinations, experiencing different cultures, and engaging in activities that are unique to the place visited. Traveling can be done by various means, such as air, land, or sea, and can range from short trips to long-term stays in a particular location. It can be an enriching experience that broadens one's horizons, provides opportunities for personal growth, and creates lasting memories. Traveling can also have practical benefits, such as developing language skills, building new relationships, and gaining new perspectives on life.", "Easy", "Traveling" }
                });

            migrationBuilder.InsertData(
                table: "MemberInfo",
                columns: new[] { "id", "birthdate", "college_program", "favorite_food_id", "first_name", "hobby_id", "last_name", "pet_id", "year" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", 1, "Adam", 1, "Tulloss", 1, "Sophmore" },
                    { 2, new DateTime(2001, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", 2, "Zach", 2, "Pittman", 2, "Senior" },
                    { 3, new DateTime(2003, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", 3, "Drew", 3, "Miluk", 3, "Sophmore" }
                });

            migrationBuilder.InsertData(
                table: "MemberPets",
                columns: new[] { "id", "age", "gender", "name", "type" },
                values: new object[,]
                {
                    { 1, 5, "Female", "Chrissy", "Dog" },
                    { 2, 1, "Male", "Noodle", "Snake" },
                    { 3, 4, "Female", "Coco", "Dog" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FavoriteFood",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FavoriteFood",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FavoriteFood",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FavoriteFood",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MemberInfo",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MemberInfo",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MemberInfo",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MemberPets",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MemberPets",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MemberPets",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
