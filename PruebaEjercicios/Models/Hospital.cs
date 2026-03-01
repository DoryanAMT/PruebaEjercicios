using System;
using System.Collections.Generic;

namespace PruebaEjercicios.Models;

public partial class Hospital
{
    public int? HospitalCod { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public int? NumCama { get; set; }
}
