using System;
using System.Collections.Generic;

namespace ControlInventario.Models;

public partial class Tproveedore
{
    public int ProvId { get; set; }

    public string ProvName { get; set; } = null!;

    public DateTime? ProvIni { get; set; }

    public DateTime? ProvFin { get; set; }

    public virtual ICollection<Tarticulo> Tarticulos { get; set; } = new List<Tarticulo>();
}
