﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SoftwareArchitecture.Data.Prototype;

namespace SoftwareArchitecture.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseContext : DbContext, IPrototype
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SiteInfo> Sites { get; set; }
        public virtual DbSet<Users> Users { get; set; }


    }
}
