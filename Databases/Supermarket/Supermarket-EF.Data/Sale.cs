//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermarket_EF.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int Quanity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Sum { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
