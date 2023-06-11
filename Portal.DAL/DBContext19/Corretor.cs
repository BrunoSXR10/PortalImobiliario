using System;
using System.Collections.Generic;

namespace Portal.DAL.DBContext19;

public partial class Corretor
{
    public int IdCorretor { get; set; }

    public string Nome { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public int Cpf { get; set; }

    public DateTime DtNascimento { get; set; }

    public string? Deputado { get; set; }
}
