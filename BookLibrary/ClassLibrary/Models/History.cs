using System;
using System.Collections.Generic;

namespace ClassLibrary.Models;

public partial class History
{
    public int HistoryId { get; set; }

    public int? LibrarianId { get; set; }

    public int StudentId { get; set; }

    public int BookId { get; set; }

    public DateTime? BorrowDate { get; set; }

    public DateTime? ReturnDeadline { get; set; }

    public DateTime? ReturnedDate { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Account Librarian { get; set; } = null!;

    public virtual Account Student { get; set; } = null!;
}
