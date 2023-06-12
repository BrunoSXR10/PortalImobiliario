using System;
using System.Collections.Generic;

namespace Portal.MODEL;

public partial class TbImovel
{
    public int IdImovel { get; set; }

    public string Descricao { get; set; } = null!;

    public double Valor { get; set; }

    public int IdEndereco { get; set; }

    public int IdCorretor { get; set; }

    public virtual TbCorretor IdCorretorNavigation { get; set; } = null!;

    public virtual TbEndereco IdEnderecoNavigation { get; set; } = null!;
}
