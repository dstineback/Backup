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

    public partial class TestpointReadings : XPLiteObject
    {
        int fnTestPointReadingID;
        [Key(true)]
        public int nTestPointReadingID
        {
            get { return fnTestPointReadingID; }
            set { SetPropertyValue<int>("nTestPointReadingID", ref fnTestPointReadingID, value); }
        }
        Testpoints fn_testpointid;
        [Association(@"TestpointReadingsReferencesTestpoints")]
        public Testpoints n_testpointid
        {
            get { return fn_testpointid; }
            set { SetPropertyValue<Testpoints>("n_testpointid", ref fn_testpointid, value); }
        }
        Jobs fn_jobid;
        [Association(@"TestpointReadingsReferencesJobs")]
        public Jobs n_jobid
        {
            get { return fn_jobid; }
            set { SetPropertyValue<Jobs>("n_jobid", ref fn_jobid, value); }
        }
        MaintenanceObjects fn_objectid;
        [Association(@"TestpointReadingsReferencesMaintenanceObjects")]
        public MaintenanceObjects n_objectid
        {
            get { return fn_objectid; }
            set { SetPropertyValue<MaintenanceObjects>("n_objectid", ref fn_objectid, value); }
        }
        int fEnteredBy;
        public int EnteredBy
        {
            get { return fEnteredBy; }
            set { SetPropertyValue<int>("EnteredBy", ref fEnteredBy, value); }
        }
        decimal freading;
        public decimal reading
        {
            get { return freading; }
            set { SetPropertyValue<decimal>("reading", ref freading, value); }
        }
        decimal fpct_change;
        public decimal pct_change
        {
            get { return fpct_change; }
            set { SetPropertyValue<decimal>("pct_change", ref fpct_change, value); }
        }
        DateTime freading_ts;
        public DateTime reading_ts
        {
            get { return freading_ts; }
            set { SetPropertyValue<DateTime>("reading_ts", ref freading_ts, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"TestpointReadingsReferencesMPetUsers")]
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
        [Association(@"TestpointReadingsReferencesMPetUsers1")]
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
    }

}