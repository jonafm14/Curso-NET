﻿namespace NETAPI.Models;

public class User
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string Apellido { get; set; } = string.Empty;

    public List<Habilidad>? Habilidades { get; set; }
}
