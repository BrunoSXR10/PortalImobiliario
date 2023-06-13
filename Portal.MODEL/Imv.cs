using System;
using System.Collections.Generic;

namespace Portal.DAL.DBContext;

public partial class Imv
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public float? Valor { get; set; }

    public string? Local { get; set; }
}
