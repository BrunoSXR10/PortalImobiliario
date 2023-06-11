using System;
using System.Collections.Generic;

namespace Portal.DAL.DBContext19;

public partial class TbEndereco
{
    public int IdEndereco { get; set; }

    public int Numero { get; set; }

    public string Logradoro { get; set; } = null!;

    public string? Complemento { get; set; }

    public int Cep { get; set; }

    public virtual ICollection<TbImovel> TbImovels { get; set; } = new List<TbImovel>();
}
