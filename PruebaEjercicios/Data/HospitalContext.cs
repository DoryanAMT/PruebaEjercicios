using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaEjercicios.Models;

public partial class HospitalContext : DbContext
{
    public HospitalContext()
    {
    }

    public HospitalContext(DbContextOptions<HospitalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Enfermo> Enfermos { get; set; }

    public virtual DbSet<Hospital> Hospitals { get; set; }

    public virtual DbSet<Ocupacion> Ocupacions { get; set; }

    public virtual DbSet<Plantilla> Plantillas { get; set; }

    public virtual DbSet<Sala> Salas { get; set; }

    public virtual DbSet<VDepartamentosIndividual> VDepartamentosIndividuals { get; set; }

    public virtual DbSet<VEmpleadosHospital> VEmpleadosHospitals { get; set; }

    public virtual DbSet<VGrupoEmpleado> VGrupoEmpleados { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DEPT");

            entity.Property(e => e.DeptNo).HasColumnName("DEPT_NO");
            entity.Property(e => e.Dnombre)
                .HasMaxLength(50)
                .HasColumnName("DNOMBRE");
            entity.Property(e => e.Loc)
                .HasMaxLength(50)
                .HasColumnName("LOC");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DOCTOR");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.DoctorNo).HasColumnName("DOCTOR_NO");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(50)
                .HasColumnName("ESPECIALIDAD");
            entity.Property(e => e.HospitalCod).HasColumnName("HOSPITAL_COD");
            entity.Property(e => e.Salario).HasColumnName("SALARIO");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EMP");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Comision).HasColumnName("COMISION");
            entity.Property(e => e.DeptNo).HasColumnName("DEPT_NO");
            entity.Property(e => e.Dir).HasColumnName("DIR");
            entity.Property(e => e.EmpNo).HasColumnName("EMP_NO");
            entity.Property(e => e.FechaAlt)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ALT");
            entity.Property(e => e.Oficio)
                .HasMaxLength(50)
                .HasColumnName("OFICIO");
            entity.Property(e => e.Salario).HasColumnName("SALARIO");
        });

        modelBuilder.Entity<Enfermo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ENFERMO");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NAC");
            entity.Property(e => e.Inscripcion)
                .HasMaxLength(50)
                .HasColumnName("INSCRIPCION");
            entity.Property(e => e.Nss)
                .HasMaxLength(50)
                .HasColumnName("NSS");
            entity.Property(e => e.S).HasMaxLength(50);
        });

        modelBuilder.Entity<Hospital>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HOSPITAL");

            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.HospitalCod).HasColumnName("HOSPITAL_COD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumCama).HasColumnName("NUM_CAMA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<Ocupacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OCUPACION");

            entity.Property(e => e.Cama).HasColumnName("CAMA");
            entity.Property(e => e.HospitalCod).HasColumnName("HOSPITAL_COD");
            entity.Property(e => e.Inscripcion).HasColumnName("INSCRIPCION");
            entity.Property(e => e.SalaCod).HasColumnName("SALA_COD");
        });

        modelBuilder.Entity<Plantilla>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLANTILLA");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.EmpleadoNo).HasColumnName("EMPLEADO_NO");
            entity.Property(e => e.Funcion)
                .HasMaxLength(50)
                .HasColumnName("FUNCION");
            entity.Property(e => e.HospitalCod).HasColumnName("HOSPITAL_COD");
            entity.Property(e => e.SalaCod).HasColumnName("SALA_COD");
            entity.Property(e => e.Salario).HasColumnName("SALARIO");
            entity.Property(e => e.T).HasMaxLength(50);
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SALA");

            entity.Property(e => e.HospitalCod).HasColumnName("HOSPITAL_COD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumCama).HasColumnName("NUM_CAMA");
            entity.Property(e => e.SalaCod).HasColumnName("SALA_COD");
        });

        modelBuilder.Entity<VDepartamentosIndividual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_DEPARTAMENTOS_INDIVIDUAL");

            entity.Property(e => e.DeptNo).HasColumnName("DEPT_NO");
            entity.Property(e => e.Dnombre)
                .HasMaxLength(50)
                .HasColumnName("DNOMBRE");
            entity.Property(e => e.Loc)
                .HasMaxLength(50)
                .HasColumnName("LOC");
            entity.Property(e => e.Posicion).HasColumnName("POSICION");
        });

        modelBuilder.Entity<VEmpleadosHospital>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_empleados_hospital");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(50)
                .HasColumnName("especialidad");
            entity.Property(e => e.HospitalCod).HasColumnName("hospital_cod");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Salario).HasColumnName("salario");
        });

        modelBuilder.Entity<VGrupoEmpleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_GRUPO_EMPLEADOS");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.DeptNo).HasColumnName("DEPT_NO");
            entity.Property(e => e.EmpNo).HasColumnName("EMP_NO");
            entity.Property(e => e.Oficio)
                .HasMaxLength(50)
                .HasColumnName("OFICIO");
            entity.Property(e => e.Posicion).HasColumnName("POSICION");
            entity.Property(e => e.Salario).HasColumnName("SALARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
