using System;
using System.Collections.Generic;

namespace _3fazis.Models;

public partial class Eladasok
{
    public int Id { get; set; }

    public int? TermekekId { get; set; }

    public int? VevokId { get; set; }

    public DateTime? Datum { get; set; }

    public int? Mennyiseg { get; set; }

    public virtual Termékek? Termekek { get; set; }

    public virtual Vevok? Vevok { get; set; }
}
