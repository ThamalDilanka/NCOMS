﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCOMS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NCOMSEntities : DbContext
    {
        public NCOMSEntities()
            : base("name=NCOMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GO> GOS { get; set; }
        public virtual DbSet<GOS_Material> GOS_Material { get; set; }
        public virtual DbSet<GOS_Money_Status> GOS_Money_Status { get; set; }
        public virtual DbSet<GRN> GRNs { get; set; }
        public virtual DbSet<GRN_Material> GRN_Material { get; set; }
        public virtual DbSet<Head_Office_Expenses> Head_Office_Expenses { get; set; }
        public virtual DbSet<Issue_From_Stock> Issue_From_Stock { get; set; }
        public virtual DbSet<Issue_From_Stock_Material> Issue_From_Stock_Material { get; set; }
        public virtual DbSet<Labor> Labors { get; set; }
        public virtual DbSet<Labor_advance> Labor_advance { get; set; }
        public virtual DbSet<Labor_Attendance> Labor_Attendance { get; set; }
        public virtual DbSet<Labor_Mobile> Labor_Mobile { get; set; }
        public virtual DbSet<Labor_OT> Labor_OT { get; set; }
        public virtual DbSet<Money_Request> Money_Request { get; set; }
        public virtual DbSet<Money_Request_Status> Money_Request_Status { get; set; }
        public virtual DbSet<Order_Material> Order_Material { get; set; }
        public virtual DbSet<Order_Status> Order_Status { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Petty_Cash> Petty_Cash { get; set; }
        public virtual DbSet<Purchase_InTo_Stock> Purchase_InTo_Stock { get; set; }
        public virtual DbSet<Purchase_InTo_Stock_Material> Purchase_InTo_Stock_Material { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Site_Material_Report> Site_Material_Report { get; set; }
        public virtual DbSet<Site_Note> Site_Note { get; set; }
        public virtual DbSet<Site_Other_Expenses> Site_Other_Expenses { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Staff_Allocated_Site> Staff_Allocated_Site { get; set; }
        public virtual DbSet<Staff_Attendance> Staff_Attendance { get; set; }
        public virtual DbSet<Staff_Mobile> Staff_Mobile { get; set; }
        public virtual DbSet<Staff_OT> Staff_OT { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<Tool_Allocation> Tool_Allocation { get; set; }
        public virtual DbSet<Tool_Repairs> Tool_Repairs { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Vehicle_Repairs> Vehicle_Repairs { get; set; }
        public virtual DbSet<Weather_Report> Weather_Report { get; set; }
    }
}
