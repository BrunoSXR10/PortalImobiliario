using System;
using System.Collections.Generic;

namespace Portal.MODEL;

public partial class Imovel
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public float? Valor { get; set; }

    public string? Localizacao { get; set; }
}
