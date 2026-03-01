using System;
using System.Collections.Generic;

namespace PruebaEjercicios.Models;

public partial class VGrupoEmpleado
{
    public int? Posicion { get; set; }

    public int? EmpNo { get; set; }

    public string? Apellido { get; set; }

    public string? Oficio { get; set; }

    public int? Salario { get; set; }

    public int? DeptNo { get; set; }
}
