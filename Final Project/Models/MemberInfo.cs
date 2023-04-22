using System;
using System.Collections.Generic;

namespace Final_Project.Models;

public partial class MemberInfo
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? CollegeProgram { get; set; }

    public string? Year { get; set; }

    public int? HobbyId { get; set; }

    public int? PetId { get; set; }

    public int? FavoriteFoodId { get; set; }
}
