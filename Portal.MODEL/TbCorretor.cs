using System;
using System.Collections.Generic;

namespace Portal.MODEL;

public partial class TbCorretor
{
    public int IdCorretor { get; set; }

    public string Nome { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public int Cpf { get; set; }

    public DateTime DtNascimento { get; set; }

    public string? Deputado { get; set; }

    public virtual ICollection<TbImovel> TbImovels { get; set; } = new List<TbImovel>();
}
