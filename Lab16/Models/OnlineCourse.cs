//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab16.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OnlineCourse
    {
        public int CourseID { get; set; }
        public string URL { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
