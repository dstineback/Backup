//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace MpetDataModel.cs
{

    [NonPersistent]
    public partial class filter_GetFilteredPayItemLinkListResult
    {
        public int n_ProjectPayItemID { get; set; }
        public int n_PayItemID { get; set; }
        public int n_ProjectID { get; set; }
        public string PayItemID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public int n_UnitOfMeasure { get; set; }
        public string UnitsOfMeasure { get; set; }
        public string b_IsActive { get; set; }
        public string b_IsSingleUse { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost { get; set; }
    }

}
