using System;
using System.Collections.Generic;

namespace ControlInventario.Models;

public partial class Tarticulo
{
    public int Aid { get; set; }

    public string Anombre { get; set; } = null!;

    public string Adescripcion { get; set; } = null!;

    public int Acantidad { get; set; }

    public int AcreatedBy { get; set; }

    public decimal Avalor { get; set; }

    public int Apid { get; set; }

    public virtual Tusuario AcreatedByNavigation { get; set; } = null!;

    public virtual Tproveedore Ap { get; set; } = null!;
}
