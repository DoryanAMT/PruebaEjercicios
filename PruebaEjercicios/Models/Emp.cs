using System;
using System.Collections.Generic;

namespace PruebaEjercicios.Models;

public partial class Emp
{
    public int? EmpNo { get; set; }

    public string? Apellido { get; set; }

    public string? Oficio { get; set; }

    public int? Dir { get; set; }

    public DateTime? FechaAlt { get; set; }

    public int? Salario { get; set; }

    public int? Comision { get; set; }

    public int? DeptNo { get; set; }
}
