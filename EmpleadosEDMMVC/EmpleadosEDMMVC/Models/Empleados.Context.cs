﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpleadosEDMMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmpleadosEDMEntities : DbContext
    {
        public EmpleadosEDMEntities()
            : base("name=EmpleadosEDMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Empleado_Detalles> Empleado_Detalles { get; set; }
        public virtual DbSet<Empleado_Experiencia_Estadisticas> Empleado_Experiencia_Estadisticas { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Empleados_Antiguedad_Estadisticas> Empleados_Antiguedad_Estadisticas { get; set; }
    }
}
