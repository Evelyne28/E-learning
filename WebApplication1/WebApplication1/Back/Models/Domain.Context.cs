﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ResearchersEntities2 : DbContext
    {
        public ResearchersEntities2()
            : base("name=ResearchersEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asistent> Asistent { get; set; }
        public virtual DbSet<Curs> Curs { get; set; }
        public virtual DbSet<DenumireCursuri> DenumireCursuri { get; set; }
        public virtual DbSet<Inscriere> Inscriere { get; set; }
        public virtual DbSet<Intrebare> Intrebare { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Raspuns> Raspuns { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Tema> Tema { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Utilizator> Utilizator { get; set; }
    }
}
