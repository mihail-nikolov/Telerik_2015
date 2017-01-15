//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetStore.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Species = new HashSet<Species>();
        }
    
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
    
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<Species> Species { get; set; }
    }
}