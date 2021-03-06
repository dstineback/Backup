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

    public partial class UnitsOfIssue : XPLiteObject
    {
        int fn_UnitsOfIssueID;
        [Key(true)]
        public int n_UnitsOfIssueID
        {
            get { return fn_UnitsOfIssueID; }
            set { SetPropertyValue<int>("n_UnitsOfIssueID", ref fn_UnitsOfIssueID, value); }
        }
        string fUnitsOfIssue1;
        [Size(50)]
        [Persistent(@"UnitsOfIssue")]
        public string UnitsOfIssue1
        {
            get { return fUnitsOfIssue1; }
            set { SetPropertyValue<string>("UnitsOfIssue1", ref fUnitsOfIssue1, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"UnitsOfIssueReferencesMPetUsers")]
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
        [Association(@"UnitsOfIssueReferencesMPetUsers1")]
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
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        [Association(@"GriefLogsReferencesUnitsOfIssue", typeof(GriefLogs))]
        public XPCollection<GriefLogs> GriefLogsCollection { get { return GetCollection<GriefLogs>("GriefLogsCollection"); } }
        [Association(@"MasterpartsReferencesUnitsOfIssue", typeof(Masterparts))]
        public XPCollection<Masterparts> MasterpartsCollection { get { return GetCollection<Masterparts>("MasterpartsCollection"); } }
        [Association(@"requisitionitemsReferencesUnitsOfIssue", typeof(requisitionitems))]
        public XPCollection<requisitionitems> requisitionitemsCollection { get { return GetCollection<requisitionitems>("requisitionitemsCollection"); } }
    }

}
