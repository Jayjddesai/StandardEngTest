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
    
    public partial class tblMachineParts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMachineParts()
        {
            this.tblMachinePartsQuotationDetail = new HashSet<tblMachinePartsQuotationDetail>();
            this.tblPerformaInvoiceDetail = new HashSet<tblPerformaInvoiceDetail>();
        }
    
        public int MachinePartId { get; set; }
        public string ProductValue { get; set; }
        public string AlternateProductValue { get; set; }
        public string AlternateProductValue1 { get; set; }
        public string Description { get; set; }
        public string IPL { get; set; }
        public string HSNCode { get; set; }
        public Nullable<decimal> STDPrice { get; set; }
        public string ProductTypeName { get; set; }
        public Nullable<int> MachineTypeId { get; set; }
        public Nullable<int> WarrantyPeriod { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual tblMachineType tblMachineType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMachinePartsQuotationDetail> tblMachinePartsQuotationDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPerformaInvoiceDetail> tblPerformaInvoiceDetail { get; set; }
    }
}