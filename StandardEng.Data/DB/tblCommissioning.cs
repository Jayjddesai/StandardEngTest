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
    
    public partial class tblCommissioning
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCommissioning()
        {
            this.tblAMCQuotation = new HashSet<tblAMCQuotation>();
            this.tblWarrantyexpires = new HashSet<tblWarrantyexpires>();
        }
    
        public int CommissioningId { get; set; }
        public Nullable<int> MachineTypeId { get; set; }
        public Nullable<int> MachineModelId { get; set; }
        public string MachineSerialNo { get; set; }
        public Nullable<int> AccessoriesTypeId { get; set; }
        public Nullable<int> MachineAccessoriesId { get; set; }
        public string AccessoriesSerialNo { get; set; }
        public int CustomerId { get; set; }
        public int ContactPersonId { get; set; }
        public string ContactPersonContactNo { get; set; }
        public string ReportServiceNo { get; set; }
        public int PreCommissioningDetailId { get; set; }
        public int ServiceEngineerId { get; set; }
        public System.DateTime CommissioningDate { get; set; }
        public System.DateTime WarrantyExpireDate { get; set; }
        public int WarrantyPeriod { get; set; }
        public string Remark { get; set; }
        public string CommissioningFileName { get; set; }
        public Nullable<bool> IsReadyForAMC { get; set; }
        public Nullable<bool> IsConvertedToAMC { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAMCQuotation> tblAMCQuotation { get; set; }
        public virtual tblMachineModels tblMachineModels { get; set; }
        public virtual tblMachineType tblMachineType { get; set; }
        public virtual tblPreCommissioningDetail tblPreCommissioningDetail { get; set; }
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWarrantyexpires> tblWarrantyexpires { get; set; }
    }
}
