using System;
using System.Collections.Generic;

namespace ControlInventario.Models;

public partial class Taccione
{
    public int AccId { get; set; }

    public string Anombre { get; set; } = null!;

    public virtual ICollection<Tregistro> Tregistros { get; set; } = new List<Tregistro>();
}
