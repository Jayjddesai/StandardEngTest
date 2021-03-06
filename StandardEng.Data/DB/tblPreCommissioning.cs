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
    
    public partial class tblPreCommissioning
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPreCommissioning()
        {
            this.tblPreCommissioningAccessories = new HashSet<tblPreCommissioningAccessories>();
            this.tblPreCommissioningDetail = new HashSet<tblPreCommissioningDetail>();
            this.tblPreCommissioningMachine = new HashSet<tblPreCommissioningMachine>();
        }
    
        public int PreCommissioningId { get; set; }
        public int CustomerId { get; set; }
        public int ContactPersonId { get; set; }
        public Nullable<bool> IsCommissioningDone { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblCustomerContactPersons tblCustomerContactPersons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPreCommissioningAccessories> tblPreCommissioningAccessories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPreCommissioningDetail> tblPreCommissioningDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPreCommissioningMachine> tblPreCommissioningMachine { get; set; }
    }
}
