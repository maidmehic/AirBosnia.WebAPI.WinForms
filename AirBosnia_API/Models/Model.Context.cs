﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirBosnia_API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirBosniaEntities : DbContext
    {
        public AirBosniaEntities()
            : base("name=AirBosniaEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Avion> Avion { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
        public virtual DbSet<Let> Let { get; set; }
        public virtual DbSet<PosadaLeta> PosadaLeta { get; set; }
        public virtual DbSet<PosebnaPonuda> PosebnaPonuda { get; set; }
        public virtual DbSet<TipZaposlenja> TipZaposlenja { get; set; }
        public virtual DbSet<Zaposlenik> Zaposlenik { get; set; }
        public virtual DbSet<Sjediste> Sjediste { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
    }
}
