﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_APTA_CMS_DEMO.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelsCMS : DbContext
    {
        public ModelsCMS()
            : base("name=ModelsCMS")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<apta_admin> apta_admins { get; set; }
        public DbSet<conference_event> conference_events { get; set; }
        public DbSet<member> members { get; set; }
        public DbSet<organizer> organizers { get; set; }
        public DbSet<teams_paper> teams_papers { get; set; }
    }
}
