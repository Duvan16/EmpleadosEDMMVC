//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Empleado_Detalles
    {
        public int Detalles_ID { get; set; }
        public Nullable<int> Empleado_ID { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> ANTIGUEDAD_Pluses { get; set; }
        public Nullable<int> Experiencia_Anios { get; set; }
        public Nullable<int> Salario { get; set; }
        public string Subcategoria { get; set; }
    
        public virtual Empleados Empleados { get; set; }
    }
}