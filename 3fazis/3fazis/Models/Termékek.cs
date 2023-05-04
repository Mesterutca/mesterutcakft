using System;
using System.Collections.Generic;

namespace _3fazis.Models;

public partial class Termékek
{
    public int Id { get; set; }

    public string? Nev { get; set; }

    public int? Ar { get; set; }

    public int? Keszlet { get; set; }

    public virtual ICollection<Eladasok> Eladasoks { get; set; } = new List<Eladasok>();
}
