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
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.Empleado_Detalles = new HashSet<Empleado_Detalles>();
            this.Empleado_Experiencia_Estadisticas = new HashSet<Empleado_Experiencia_Estadisticas>();
            this.Empleados_Antiguedad_Estadisticas = new HashSet<Empleados_Antiguedad_Estadisticas>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> ANTIGUEDAD { get; set; }
        public Nullable<int> Edad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado_Detalles> Empleado_Detalles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado_Experiencia_Estadisticas> Empleado_Experiencia_Estadisticas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados_Antiguedad_Estadisticas> Empleados_Antiguedad_Estadisticas { get; set; }
    }
}
