using System;
using System.Collections.Generic;

namespace _3fazis.Models;

public partial class Akció
{
    public int AkcióId { get; set; }

    public int? AkcióNév { get; set; }

    public bool? Aktív { get; set; }

    public int? Kedvezmény { get; set; }
}
