using System;
using System.Collections.Generic;

namespace ControlInventario.Models;

public partial class Tborrado
{
    public int Bid { get; set; }

    public string Banombre { get; set; } = null!;

    public string Badescripcion { get; set; } = null!;

    public int Bcantidad { get; set; }

    public int BdeletedBy { get; set; }

    public DateTime Bfecha { get; set; }

    public virtual Tusuario BdeletedByNavigation { get; set; } = null!;
}
