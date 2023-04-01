using System;
using System.Collections.Generic;

namespace ClassLibrary.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string? PersonName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool? Gender { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
