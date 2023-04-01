using System;
using System.Collections.Generic;

namespace ClassLibrary.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? PersonId { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<History> HistoryLibrarians { get; } = new List<History>();

    public virtual ICollection<History> HistoryStudents { get; } = new List<History>();

    public virtual Person? Person { get; set; }
}
