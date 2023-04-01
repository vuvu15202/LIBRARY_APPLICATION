using System;
using System.Collections.Generic;

namespace ClassLibrary.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? BookName { get; set; }

    public string? Category { get; set; }

    public string? Image { get; set; }

    public int? Quantity { get; set; }

    public virtual ICollection<History> Histories { get; } = new List<History>();
}
