using System;
using System.Collections.Generic;

namespace _3fazis.Models;

public partial class TermékAkció
{
    public int Id { get; set; }

    public string? TermékId { get; set; }

    public int? AkcióId { get; set; }

    public int? Leértékelés { get; set; }

    public int? ÚjÁr { get; set; }
}
