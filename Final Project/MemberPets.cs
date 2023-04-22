using System.ComponentModel;

namespace Final_Project
{
    public class MemberPets
    {
        public int Id { get; set; }

        [DisplayName("Pet Name")]
        public string ?PetName { get; set; }

        [DisplayName("Pet Type")]
        public string ?PetType { get; set; }

        [DisplayName("Pet Gender")]
        public string ?PetGender { get; set; }

        [DisplayName("Pet Age")]
        public int ?PetAge { get; set; }
    }
}