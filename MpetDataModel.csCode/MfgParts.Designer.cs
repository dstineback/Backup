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

    public partial class MfgParts : XPLiteObject
    {
        int fn_mfgpartid;
        [Key(true)]
        public int n_mfgpartid
        {
            get { return fn_mfgpartid; }
            set { SetPropertyValue<int>("n_mfgpartid", ref fn_mfgpartid, value); }
        }
        string fmfgpartid;
        [Size(50)]
        public string mfgpartid
        {
            get { return fmfgpartid; }
            set { SetPropertyValue<string>("mfgpartid", ref fmfgpartid, value); }
        }
        string fmfgpartdesc;
        [Size(254)]
        public string mfgpartdesc
        {
            get { return fmfgpartdesc; }
            set { SetPropertyValue<string>("mfgpartdesc", ref fmfgpartdesc, value); }
        }
        Manufacturers fn_mfgid;
        [Association(@"MfgPartsReferencesManufacturers")]
        public Manufacturers n_mfgid
        {
            get { return fn_mfgid; }
            set { SetPropertyValue<Manufacturers>("n_mfgid", ref fn_mfgid, value); }
        }
        Masterparts fn_masterpartid;
        [Association(@"MfgPartsReferencesMasterparts")]
        public Masterparts n_masterpartid
        {
            get { return fn_masterpartid; }
            set { SetPropertyValue<Masterparts>("n_masterpartid", ref fn_masterpartid, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"MfgPartsReferencesMPetUsers")]
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
        [Association(@"MfgPartsReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fLast_modified;
        public DateTime Last_modified
        {
            get { return fLast_modified; }
            set { SetPropertyValue<DateTime>("Last_modified", ref fLast_modified, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        [Association(@"CycleCountsReferencesMfgParts", typeof(CycleCounts))]
        public XPCollection<CycleCounts> CycleCountsCollection { get { return GetCollection<CycleCounts>("CycleCountsCollection"); } }
        [Association(@"JobPartsReferencesMfgParts", typeof(JobParts))]
        public XPCollection<JobParts> JobPartsCollection { get { return GetCollection<JobParts>("JobPartsCollection"); } }
        [Association(@"StoresIssueItemsReferencesMfgParts", typeof(StoresIssueItems))]
        public XPCollection<StoresIssueItems> StoresIssueItemsCollection { get { return GetCollection<StoresIssueItems>("StoresIssueItemsCollection"); } }
        [Association(@"VendorPartsReferencesMfgParts", typeof(VendorParts))]
        public XPCollection<VendorParts> VendorPartsCollection { get { return GetCollection<VendorParts>("VendorPartsCollection"); } }
    }

}
