﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarhatnieBrovki.DatabaseField
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BarhatniyeBrovkiEntities : DbContext
    {
        public BarhatniyeBrovkiEntities()
            : base("name=BarhatniyeBrovkiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientServices> ClientServices { get; set; }
        public virtual DbSet<DocumentByServices> DocumentByServices { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<ProductPhotoes> ProductPhotoes { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductSales> ProductSales { get; set; }
        public virtual DbSet<ServicePhotoes> ServicePhotoes { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
    }
}
