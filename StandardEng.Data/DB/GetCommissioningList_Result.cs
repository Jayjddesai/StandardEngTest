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
    
    public partial class GetCommissioningList_Result
    {
        public int CommissioningId { get; set; }
        public string MachineTypeName { get; set; }
        public string MachineName { get; set; }
        public string MachineSerialNo { get; set; }
        public string AccessoriesTypeName { get; set; }
        public string AccessoriesName { get; set; }
        public string AccessoriesSerialNo { get; set; }
        public string CustomerName { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactNo { get; set; }
        public string ContactPersonEmail { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string ServiceEnginnerName { get; set; }
        public System.DateTime CommissioningDate { get; set; }
        public System.DateTime WarrantyExpireDate { get; set; }
        public Nullable<int> RemainingDays { get; set; }
        public Nullable<bool> IsReadyForAMC { get; set; }
        public Nullable<bool> IsConvertedToAMC { get; set; }
    }
}
