﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotoRandApplication.database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MotoRandEntities : DbContext
    {
        public MotoRandEntities()
            : base("name=MotoRandEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abakan_Street> Abakan_Street { get; set; }
        public virtual DbSet<CashBox> CashBox { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CountryMoto> CountryMoto { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Motorcycle> Motorcycle { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<PhoneBook> PhoneBook { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeComponent> TypeComponent { get; set; }
        public virtual DbSet<TypePart> TypePart { get; set; }
    }
}
