﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProjeOrnek.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<plazalar> plazalarSet { get; set; }
        public virtual DbSet<firmalar> firmalarSet { get; set; }
        public virtual DbSet<departmanlar> departmanlarSet { get; set; }
        public virtual DbSet<calisanlar> calisanlarSet { get; set; }
        public virtual DbSet<Kullanicilar> KullanicilarSet { get; set; }
    }
}
