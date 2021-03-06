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

    public partial class StoresIssueItems : XPLiteObject
    {
        int fn_StoresIssueItemid;
        [Key(true)]
        public int n_StoresIssueItemid
        {
            get { return fn_StoresIssueItemid; }
            set { SetPropertyValue<int>("n_StoresIssueItemid", ref fn_StoresIssueItemid, value); }
        }
        StoresIssues fn_StoresIssueID;
        [Association(@"StoresIssueItemsReferencesStoresIssues")]
        public StoresIssues n_StoresIssueID
        {
            get { return fn_StoresIssueID; }
            set { SetPropertyValue<StoresIssues>("n_StoresIssueID", ref fn_StoresIssueID, value); }
        }
        Masterparts fn_MasterPartID;
        [Association(@"StoresIssueItemsReferencesMasterparts")]
        public Masterparts n_MasterPartID
        {
            get { return fn_MasterPartID; }
            set { SetPropertyValue<Masterparts>("n_MasterPartID", ref fn_MasterPartID, value); }
        }
        int fQtyRequested;
        public int QtyRequested
        {
            get { return fQtyRequested; }
            set { SetPropertyValue<int>("QtyRequested", ref fQtyRequested, value); }
        }
        int fQtyIssued;
        public int QtyIssued
        {
            get { return fQtyIssued; }
            set { SetPropertyValue<int>("QtyIssued", ref fQtyIssued, value); }
        }
        string fb_DemandSatisfied;
        [Size(1)]
        public string b_DemandSatisfied
        {
            get { return fb_DemandSatisfied; }
            set { SetPropertyValue<string>("b_DemandSatisfied", ref fb_DemandSatisfied, value); }
        }
        MfgParts fn_MfgPartID;
        [Association(@"StoresIssueItemsReferencesMfgParts")]
        public MfgParts n_MfgPartID
        {
            get { return fn_MfgPartID; }
            set { SetPropertyValue<MfgParts>("n_MfgPartID", ref fn_MfgPartID, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"StoresIssueItemsReferencesMPetUsers")]
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
        [Association(@"StoresIssueItemsReferencesMPetUsers1")]
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
        ObjectCodes fn_ObjectCodeID;
        [Association(@"StoresIssueItemsReferencesObjectCodes")]
        public ObjectCodes n_ObjectCodeID
        {
            get { return fn_ObjectCodeID; }
            set { SetPropertyValue<ObjectCodes>("n_ObjectCodeID", ref fn_ObjectCodeID, value); }
        }
        [Association(@"JobPartsReferencesStoresIssueItems", typeof(JobParts))]
        public XPCollection<JobParts> JobPartsCollection { get { return GetCollection<JobParts>("JobPartsCollection"); } }
    }

}
