﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnderWorld
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UnderWorldEntities : DbContext
    {
        public UnderWorldEntities()
            : base("name=UnderWorldEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<album> album { get; set; }
        public virtual DbSet<artista> artista { get; set; }
        public virtual DbSet<musica> musica { get; set; }
        public virtual DbSet<playlist> playlist { get; set; }
        public virtual DbSet<relacionado> relacionado { get; set; }
        public virtual DbSet<seguir> seguir { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
