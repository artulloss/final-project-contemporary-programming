using System;
using System.Collections.Generic;

namespace Final_Project.Models;

public partial class Hobby
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public string? Difficulty { get; set; }
}
