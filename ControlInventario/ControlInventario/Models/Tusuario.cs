using System;
using System.Collections.Generic;

namespace ControlInventario.Models;

public partial class Tusuario
{
    public int UserId { get; set; }

    public byte[]? Uhpass { get; set; }

    public int UprivId { get; set; }

    public DateTime Ucreated { get; set; }

    public DateTime UlastLogin { get; set; }

    public bool Ustatus { get; set; }

    public virtual ICollection<Tarticulo> Tarticulos { get; set; } = new List<Tarticulo>();

    public virtual ICollection<Tborrado> Tborrados { get; set; } = new List<Tborrado>();

    public virtual ICollection<Tregistro> Tregistros { get; set; } = new List<Tregistro>();

    public virtual Tperfile Upriv { get; set; } = null!;
}
