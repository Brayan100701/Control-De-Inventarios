using System;
using System.Collections.Generic;

namespace ControlInventario.Models;

public partial class Tregistro
{
    public int Rid { get; set; }

    public DateTime Rfecha { get; set; }

    public int RaccionId { get; set; }

    public int RmodifiedBy { get; set; }

    public virtual Taccione Raccion { get; set; } = null!;

    public virtual Tusuario RmodifiedByNavigation { get; set; } = null!;
}
