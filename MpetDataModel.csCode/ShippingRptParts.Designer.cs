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

    public partial class ShippingRptParts : XPLiteObject
    {
        int fn_ShippingRptItemID;
        [Key(true)]
        public int n_ShippingRptItemID
        {
            get { return fn_ShippingRptItemID; }
            set { SetPropertyValue<int>("n_ShippingRptItemID", ref fn_ShippingRptItemID, value); }
        }
        ShippingReports fn_ShippingRptID;
        [Association(@"ShippingRptPartsReferencesShippingReports")]
        public ShippingReports n_ShippingRptID
        {
            get { return fn_ShippingRptID; }
            set { SetPropertyValue<ShippingReports>("n_ShippingRptID", ref fn_ShippingRptID, value); }
        }
        string fPartID;
        [Size(50)]
        public string PartID
        {
            get { return fPartID; }
            set { SetPropertyValue<string>("PartID", ref fPartID, value); }
        }
        string fPartDescr;
        [Size(254)]
        public string PartDescr
        {
            get { return fPartDescr; }
            set { SetPropertyValue<string>("PartDescr", ref fPartDescr, value); }
        }
        int fQty;
        public int Qty
        {
            get { return fQty; }
            set { SetPropertyValue<int>("Qty", ref fQty, value); }
        }
        string fUnitOfMeasure;
        [Size(24)]
        public string UnitOfMeasure
        {
            get { return fUnitOfMeasure; }
            set { SetPropertyValue<string>("UnitOfMeasure", ref fUnitOfMeasure, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"ShippingRptPartsReferencesMPetUsers")]
        public MPetUsers CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<MPetUsers>("CreatedBy", ref fCreatedBy, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        MPetUsers fModifiedBy;
        [Association(@"ShippingRptPartsReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fModifiedOn;
        public DateTime ModifiedOn
        {
            get { return fModifiedOn; }
            set { SetPropertyValue<DateTime>("ModifiedOn", ref fModifiedOn, value); }
        }
    }

}
