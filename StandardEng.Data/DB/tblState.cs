//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StandardEng.Data.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblState()
        {
            this.tblCity = new HashSet<tblCity>();
            this.tblCustomer = new HashSet<tblCustomer>();
        }
    
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCity> tblCity { get; set; }
        public virtual tblCountry tblCountry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomer { get; set; }
    }
}