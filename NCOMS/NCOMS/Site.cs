//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Site()
        {
            this.GRNs = new HashSet<GRN>();
            this.Issue_From_Stock = new HashSet<Issue_From_Stock>();
            this.Labors = new HashSet<Labor>();
            this.Money_Request = new HashSet<Money_Request>();
            this.Site_Material_Report = new HashSet<Site_Material_Report>();
            this.Site_Other_Expenses = new HashSet<Site_Other_Expenses>();
            this.Staff_Allocated_Site = new HashSet<Staff_Allocated_Site>();
            this.Tool_Allocation = new HashSet<Tool_Allocation>();
            this.Weather_Report = new HashSet<Weather_Report>();
        }
    
        public int site_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> deadline { get; set; }
        public Nullable<float> estimated_cost { get; set; }
        public string state { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRN> GRNs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issue_From_Stock> Issue_From_Stock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Labor> Labors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Money_Request> Money_Request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Site_Material_Report> Site_Material_Report { get; set; }
        public virtual Site_Note Site_Note { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Site_Other_Expenses> Site_Other_Expenses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Allocated_Site> Staff_Allocated_Site { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tool_Allocation> Tool_Allocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Weather_Report> Weather_Report { get; set; }
    }
}
