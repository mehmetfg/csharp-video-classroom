﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduCommerce.Web
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KariyerPoliklinikDBEntities : DbContext
    {
        public KariyerPoliklinikDBEntities()
            : base("name=KariyerPoliklinikDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Current> Current { get; set; }
        public virtual DbSet<Dealers> Dealers { get; set; }
        public virtual DbSet<Educations> Educations { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Reference> Reference { get; set; }
        public virtual DbSet<Students> Students { get; set; }
    }
}
