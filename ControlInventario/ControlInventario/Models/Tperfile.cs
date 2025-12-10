using System;
using System.Collections.Generic;

namespace ControlInventario.Models;

public partial class Tperfile
{
    public int PerId { get; set; }

    public string? Pnombre { get; set; }

    public string? Ppermisos { get; set; }

    public virtual ICollection<Tusuario> Tusuarios { get; set; } = new List<Tusuario>();
}
