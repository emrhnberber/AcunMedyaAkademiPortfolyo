﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcunMedyaAkademiPortfolyo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbAcunmedyaAkademi1Entities : DbContext
    {
        public DbAcunmedyaAkademi1Entities()
            : base("name=DbAcunmedyaAkademi1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblProject> TblProject { get; set; }
        public virtual DbSet<TblExperience> TblExperience { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblTestimonial> TblTestimonial { get; set; }
        public virtual DbSet<TblEducation> TblEducation { get; set; }
        public virtual DbSet<TblMessage> TblMessage { get; set; }
        public virtual DbSet<TblSkill> TblSkill { get; set; }
        public virtual DbSet<TblStats> TblStats { get; set; }
        public virtual DbSet<TblAbout> TblAbout { get; set; }
        public virtual DbSet<TblContacts> TblContacts { get; set; }
    }
}
