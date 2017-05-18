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

    public partial class ProductLineTypes : XPLiteObject
    {
        int fn_prodlineid;
        [Key(true)]
        public int n_prodlineid
        {
            get { return fn_prodlineid; }
            set { SetPropertyValue<int>("n_prodlineid", ref fn_prodlineid, value); }
        }
        string fprodlineid;
        [Size(10)]
        public string prodlineid
        {
            get { return fprodlineid; }
            set { SetPropertyValue<string>("prodlineid", ref fprodlineid, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        decimal fdollardown;
        public decimal dollardown
        {
            get { return fdollardown; }
            set { SetPropertyValue<decimal>("dollardown", ref fdollardown, value); }
        }
        decimal fUnitsLost;
        public decimal UnitsLost
        {
            get { return fUnitsLost; }
            set { SetPropertyValue<decimal>("UnitsLost", ref fUnitsLost, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"ProductLineTypesReferencesMPetUsers")]
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
        [Association(@"ProductLineTypesReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fLast_Modified;
        public DateTime Last_Modified
        {
            get { return fLast_Modified; }
            set { SetPropertyValue<DateTime>("Last_Modified", ref fLast_Modified, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        [Association(@"MaintenanceObjectsReferencesProductLineTypes", typeof(MaintenanceObjects))]
        public XPCollection<MaintenanceObjects> MaintenanceObjectsCollection { get { return GetCollection<MaintenanceObjects>("MaintenanceObjectsCollection"); } }
    }

}