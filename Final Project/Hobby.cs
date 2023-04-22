using System.ComponentModel;

namespace Final_Project
{
    public class Hobby
    {
        public int Id { get; set; }

        [DisplayName("Hobby Name")]
        public string ?Name { get; set; }

        [DisplayName("Hobby Category")]
        public string ?Category { get; set; }

        [DisplayName("Hobby Description")]
        public string ?Description { get; set; }

        [DisplayName("Hobby Difficulty")]
        public string ?Difficulty { get; set; }
    }
}
