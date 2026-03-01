using System;
using System.Collections.Generic;

namespace PruebaEjercicios.Models;

public partial class Doctor
{
    public int? HospitalCod { get; set; }

    public int? DoctorNo { get; set; }

    public string? Apellido { get; set; }

    public string? Especialidad { get; set; }

    public int? Salario { get; set; }
}
