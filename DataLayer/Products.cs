//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Product_Features = new HashSet<Product_Features>();
            this.Product_Galleries = new HashSet<Product_Galleries>();
            this.Product_Selected_Groups = new HashSet<Product_Selected_Groups>();
            this.Product_Tags = new HashSet<Product_Tags>();
            this.Product_Comments = new HashSet<Product_Comments>();
            this.FactorDetails = new HashSet<FactorDetails>();
        }
    
        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> OldPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Features> Product_Features { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Galleries> Product_Galleries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Selected_Groups> Product_Selected_Groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Tags> Product_Tags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Comments> Product_Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactorDetails> FactorDetails { get; set; }
    }
}
