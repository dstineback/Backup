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

    public partial class CostCodes : XPLiteObject
    {
        int fn_costcodeid;
        [Key(true)]
        public int n_costcodeid
        {
            get { return fn_costcodeid; }
            set { SetPropertyValue<int>("n_costcodeid", ref fn_costcodeid, value); }
        }
        string fcostcodeid;
        [Size(20)]
        public string costcodeid
        {
            get { return fcostcodeid; }
            set { SetPropertyValue<string>("costcodeid", ref fcostcodeid, value); }
        }
        string fdescr;
        [Size(254)]
        public string descr
        {
            get { return fdescr; }
            set { SetPropertyValue<string>("descr", ref fdescr, value); }
        }
        string fSupplementalCode;
        public string SupplementalCode
        {
            get { return fSupplementalCode; }
            set { SetPropertyValue<string>("SupplementalCode", ref fSupplementalCode, value); }
        }
        int ftasknum;
        public int tasknum
        {
            get { return ftasknum; }
            set { SetPropertyValue<int>("tasknum", ref ftasknum, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"CostCodesReferencesMPetUsers")]
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
        [Association(@"CostCodesReferencesMPetUsers1")]
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
        [Association(@"AreasReferencesCostCodes", typeof(Areas))]
        public XPCollection<Areas> AreasCollection { get { return GetCollection<Areas>("AreasCollection"); } }
        [Association(@"CostCodeLinksReferencesCostCodes", typeof(CostCodeLinks))]
        public XPCollection<CostCodeLinks> CostCodeLinksCollection { get { return GetCollection<CostCodeLinks>("CostCodeLinksCollection"); } }
        [Association(@"FieldDataCollectionReferencesCostCodes", typeof(FieldDataCollection))]
        public XPCollection<FieldDataCollection> FieldDataCollections { get { return GetCollection<FieldDataCollection>("FieldDataCollections"); } }
        [Association(@"IncidentsReferencesCostCodes", typeof(Incidents))]
        public XPCollection<Incidents> IncidentsCollection { get { return GetCollection<Incidents>("IncidentsCollection"); } }
        [Association(@"JobsReferencesCostCodes", typeof(Jobs))]
        public XPCollection<Jobs> JobsCollection { get { return GetCollection<Jobs>("JobsCollection"); } }
        [Association(@"JobstepsReferencesCostCodes", typeof(Jobsteps))]
        public XPCollection<Jobsteps> JobstepsCollection { get { return GetCollection<Jobsteps>("JobstepsCollection"); } }
        [Association(@"MaintenanceObjectsReferencesCostCodes", typeof(MaintenanceObjects))]
        public XPCollection<MaintenanceObjects> MaintenanceObjectsCollection { get { return GetCollection<MaintenanceObjects>("MaintenanceObjectsCollection"); } }
        [Association(@"ProjectDiaryReferencesCostCodes", typeof(ProjectDiary))]
        public XPCollection<ProjectDiary> ProjectDiaries { get { return GetCollection<ProjectDiary>("ProjectDiaries"); } }
        [Association(@"ProjectsReferencesCostCodes", typeof(Projects))]
        public XPCollection<Projects> ProjectsCollection { get { return GetCollection<Projects>("ProjectsCollection"); } }
        [Association(@"requisitionsReferencesCostCodes", typeof(requisitions))]
        public XPCollection<requisitions> requisitionsCollection { get { return GetCollection<requisitions>("requisitionsCollection"); } }
        [Association(@"StateRoutesReferencesCostCodes", typeof(StateRoutes))]
        public XPCollection<StateRoutes> StateRoutesCollection { get { return GetCollection<StateRoutes>("StateRoutesCollection"); } }
        [Association(@"StoresIssuesReferencesCostCodes", typeof(StoresIssues))]
        public XPCollection<StoresIssues> StoresIssuesCollection { get { return GetCollection<StoresIssues>("StoresIssuesCollection"); } }
        [Association(@"time_batch_itemsReferencesCostCodes", typeof(time_batch_items))]
        public XPCollection<time_batch_items> time_batch_itemss { get { return GetCollection<time_batch_items>("time_batch_itemss"); } }
    }

}
