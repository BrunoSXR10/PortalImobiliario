using System;
using System.Collections.Generic;

namespace Portal.MODEL;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Senha { get; set; }

    public string? Cpf { get; set; }

    public string? Deputado { get; set; }
}
