using System;
using System.Collections.Generic;

namespace _3fazis.Models;

public partial class Vevok
{
    public int Id { get; set; }

    public string? Nev { get; set; }

    public string? Telefon { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Eladasok> Eladasoks { get; set; } = new List<Eladasok>();
}
