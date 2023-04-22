using System;
using System.Collections.Generic;

namespace Final_Project.Models;

public partial class MemberPet
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }
}
