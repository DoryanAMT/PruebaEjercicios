using System;
using System.Collections.Generic;

namespace PruebaEjercicios.Models;

public partial class Enfermo
{
    public string? Inscripcion { get; set; }

    public string? Apellido { get; set; }

    public string? Direccion { get; set; }

    public DateTime? FechaNac { get; set; }

    public string? S { get; set; }

    public string? Nss { get; set; }
}
