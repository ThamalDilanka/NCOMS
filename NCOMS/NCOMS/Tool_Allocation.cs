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
    
    public partial class Tool_Allocation
    {
        public int tool_id { get; set; }
        public int site_id { get; set; }
        public System.DateTime allocated_date { get; set; }
        public Nullable<System.DateTime> release_date { get; set; }
    
        public virtual Site Site { get; set; }
        public virtual Tool Tool { get; set; }
    }
}
