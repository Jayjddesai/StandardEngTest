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
    
    public partial class tblAMCQuotation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAMCQuotation()
        {
            this.tblAMC = new HashSet<tblAMC>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CommissioningId { get; set; }
        public int CustomerId { get; set; }
        public int MachineModelId { get; set; }
        public int MachineTypeId { get; set; }
        public string MachineSerialNo { get; set; }
        public string AMCQuotationNo { get; set; }
        public System.DateTime QuotationDate { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal GSTPercentage { get; set; }
        public decimal GSTAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string TotalAmountInWords { get; set; }
        public decimal CGSTPercentage { get; set; }
        public decimal CGSTAmount { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> SequenceNo { get; set; }
        public Nullable<bool> IsConvertedIntoAMC { get; set; }
        public Nullable<bool> IsApproved { get; set; }
    
        public virtual tblMachineModels tblMachineModels { get; set; }
        public virtual tblMachineType tblMachineType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAMC> tblAMC { get; set; }
        public virtual tblCommissioning tblCommissioning { get; set; }
    }
}
