﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oybab.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tsEntities : DbContext
    {
        public tsEntities()
            : base("name=tsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AdminLog> AdminLogs { get; set; }
        public virtual DbSet<AdminPay> AdminPays { get; set; }
        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<BalancePay> BalancePays { get; set; }
        public virtual DbSet<Database> Databases { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<ImportDetail> ImportDetails { get; set; }
        public virtual DbSet<ImportPay> ImportPays { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberPay> MemberPays { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderPay> OrderPays { get; set; }
        public virtual DbSet<Ppr> Pprs { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<Printlog> Printlogs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierPay> SupplierPays { get; set; }
        public virtual DbSet<Takeout> Takeouts { get; set; }
        public virtual DbSet<TakeoutDetail> TakeoutDetails { get; set; }
        public virtual DbSet<TakeoutPay> TakeoutPays { get; set; }
    }
}