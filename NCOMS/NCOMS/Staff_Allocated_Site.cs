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
    
    public partial class Staff_Allocated_Site
    {
        public int staff_id { get; set; }
        public int site_id { get; set; }
        public Nullable<System.DateTime> started_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
    
        public virtual Site Site { get; set; }
        public virtual Staff Staff { get; set; }
    }
}