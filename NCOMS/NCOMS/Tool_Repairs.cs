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
    
    public partial class Tool_Repairs
    {
        public int tool_id { get; set; }
        public System.DateTime date { get; set; }
        public string description { get; set; }
        public string service_station { get; set; }
        public Nullable<int> bill_no { get; set; }
        public Nullable<float> cost { get; set; }
    
        public virtual Tool Tool { get; set; }
    }
}
