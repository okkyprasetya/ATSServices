using System;
using System.Collections.Generic;

namespace testCRUD.Models;

public partial class Vacancy
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Requirements { get; set; } = null!;

    public string? Salary { get; set; }

    public DateOnly Deadline { get; set; }
}
