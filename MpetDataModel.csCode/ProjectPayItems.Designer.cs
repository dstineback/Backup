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

    public partial class ProjectPayItems : XPLiteObject
    {
        int fn_PayItemID;
        [Key(true)]
        public int n_PayItemID
        {
            get { return fn_PayItemID; }
            set { SetPropertyValue<int>("n_PayItemID", ref fn_PayItemID, value); }
        }
        string fPayItemID;
        [Size(50)]
        public string PayItemID
        {
            get { return fPayItemID; }
            set { SetPropertyValue<string>("PayItemID", ref fPayItemID, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        decimal fQuantity;
        public decimal Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<decimal>("Quantity", ref fQuantity, value); }
        }
        UnitsOfMeasure fn_UnitOfMeasure;
        [Association(@"ProjectPayItemsReferencesUnitsOfMeasure")]
        public UnitsOfMeasure n_UnitOfMeasure
        {
            get { return fn_UnitOfMeasure; }
            set { SetPropertyValue<UnitsOfMeasure>("n_UnitOfMeasure", ref fn_UnitOfMeasure, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        string fb_IsSingleUse;
        [Size(1)]
        public string b_IsSingleUse
        {
            get { return fb_IsSingleUse; }
            set { SetPropertyValue<string>("b_IsSingleUse", ref fb_IsSingleUse, value); }
        }
        decimal fUnitCost;
        public decimal UnitCost
        {
            get { return fUnitCost; }
            set { SetPropertyValue<decimal>("UnitCost", ref fUnitCost, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"ProjectPayItemsReferencesMPetUsers")]
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
        [Association(@"ProjectPayItemsReferencesMPetUsers1")]
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
        [Association(@"ProjectPayItemLinksReferencesProjectPayItems", typeof(ProjectPayItemLinks))]
        public XPCollection<ProjectPayItemLinks> ProjectPayItemLinksCollection { get { return GetCollection<ProjectPayItemLinks>("ProjectPayItemLinksCollection"); } }
    }

}
