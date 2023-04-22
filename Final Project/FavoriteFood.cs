using System.ComponentModel;


namespace Final_Project
{
    public class FavoriteFood
    {
        public int Id { get; set; }

        [DisplayName("Food Name")]
        public string ?Name { get; set; }

        [DisplayName("Food Category")]
        public string ?Category { get; set; }

        [DisplayName("Food Description")]
        public string ?Description { get; set; }

        [DisplayName("Country of Origin")]
        public string ?CountryOfOrigin { get; set; }
    }

}