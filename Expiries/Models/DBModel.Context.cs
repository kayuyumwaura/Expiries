﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Expiries.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_doctors> tb_doctors { get; set; }
        public virtual DbSet<tb_icdcodes> tb_icdcodes { get; set; }
        public virtual DbSet<tb_patient_expiries> tb_patient_expiries { get; set; }
        public virtual DbSet<tb_race> tb_race { get; set; }
        public virtual DbSet<tb_users> tb_users { get; set; }
        public virtual DbSet<tb_wards> tb_wards { get; set; }
    }
}
