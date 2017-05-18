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

    public partial class ObjectCodes : XPLiteObject
    {
        int fn_ObjectCodeID;
        [Key(true)]
        public int n_ObjectCodeID
        {
            get { return fn_ObjectCodeID; }
            set { SetPropertyValue<int>("n_ObjectCodeID", ref fn_ObjectCodeID, value); }
        }
        string fObjectCodeID;
        [Size(30)]
        public string ObjectCodeID
        {
            get { return fObjectCodeID; }
            set { SetPropertyValue<string>("ObjectCodeID", ref fObjectCodeID, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"ObjectCodesReferencesMPetUsers")]
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
        [Association(@"ObjectCodesReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fLastModified;
        public DateTime LastModified
        {
            get { return fLastModified; }
            set { SetPropertyValue<DateTime>("LastModified", ref fLastModified, value); }
        }
        [Association(@"JobPartsReferencesObjectCodes", typeof(JobParts))]
        public XPCollection<JobParts> JobPartsCollection { get { return GetCollection<JobParts>("JobPartsCollection"); } }
        [Association(@"JobstepsReferencesObjectCodes", typeof(Jobsteps))]
        public XPCollection<Jobsteps> JobstepsCollection { get { return GetCollection<Jobsteps>("JobstepsCollection"); } }
        [Association(@"MasterpartsReferencesObjectCodes", typeof(Masterparts))]
        public XPCollection<Masterparts> MasterpartsCollection { get { return GetCollection<Masterparts>("MasterpartsCollection"); } }
        [Association(@"requisitionitemsReferencesObjectCodes", typeof(requisitionitems))]
        public XPCollection<requisitionitems> requisitionitemsCollection { get { return GetCollection<requisitionitems>("requisitionitemsCollection"); } }
        [Association(@"StoresIssueItemsReferencesObjectCodes", typeof(StoresIssueItems))]
        public XPCollection<StoresIssueItems> StoresIssueItemsCollection { get { return GetCollection<StoresIssueItems>("StoresIssueItemsCollection"); } }
    }

}