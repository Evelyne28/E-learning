//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Back.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tema
    {
        public int idTema { get; set; }
        public Nullable<int> nota { get; set; }
        public Nullable<int> idStudent { get; set; }
        public Nullable<int> idProfesor { get; set; }
        public Nullable<int> idAsistent { get; set; }
    
        public virtual Asistent Asistent { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Student Student { get; set; }
    }
}
