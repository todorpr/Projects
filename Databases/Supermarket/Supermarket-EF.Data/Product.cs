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
    
    public partial class Product
    {
        public Product()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int ID { get; set; }
        public Nullable<int> VendorID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> MeasureID { get; set; }
        public decimal BasePrice { get; set; }
    
        public virtual Measure Measure { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
