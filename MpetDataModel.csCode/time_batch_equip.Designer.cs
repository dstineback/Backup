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

    public partial class time_batch_equip : XPLiteObject
    {
        int fRecordID;
        [Key(true)]
        public int RecordID
        {
            get { return fRecordID; }
            set { SetPropertyValue<int>("RecordID", ref fRecordID, value); }
        }
        int fn_itemid;
        public int n_itemid
        {
            get { return fn_itemid; }
            set { SetPropertyValue<int>("n_itemid", ref fn_itemid, value); }
        }
        time_batches fn_time_batchid;
        [Association(@"time_batch_equipReferencestime_batches")]
        public time_batches n_time_batchid
        {
            get { return fn_time_batchid; }
            set { SetPropertyValue<time_batches>("n_time_batchid", ref fn_time_batchid, value); }
        }
        MaintenanceObjects fn_objectid;
        [Association(@"time_batch_equipReferencesMaintenanceObjects")]
        public MaintenanceObjects n_objectid
        {
            get { return fn_objectid; }
            set { SetPropertyValue<MaintenanceObjects>("n_objectid", ref fn_objectid, value); }
        }
        MPetUsers fn_personid;
        [Association(@"time_batch_equipReferencesMPetUsers")]
        public MPetUsers n_personid
        {
            get { return fn_personid; }
            set { SetPropertyValue<MPetUsers>("n_personid", ref fn_personid, value); }
        }
        JobEquipment fn_JobEquipment;
        [Association(@"time_batch_equipReferencesJobEquipment")]
        public JobEquipment n_JobEquipment
        {
            get { return fn_JobEquipment; }
            set { SetPropertyValue<JobEquipment>("n_JobEquipment", ref fn_JobEquipment, value); }
        }
        decimal fstart_meter;
        public decimal start_meter
        {
            get { return fstart_meter; }
            set { SetPropertyValue<decimal>("start_meter", ref fstart_meter, value); }
        }
        decimal fend_meter;
        public decimal end_meter
        {
            get { return fend_meter; }
            set { SetPropertyValue<decimal>("end_meter", ref fend_meter, value); }
        }
        decimal factual_units;
        public decimal actual_units
        {
            get { return factual_units; }
            set { SetPropertyValue<decimal>("actual_units", ref factual_units, value); }
        }
        DateTime fDateWorked;
        public DateTime DateWorked
        {
            get { return fDateWorked; }
            set { SetPropertyValue<DateTime>("DateWorked", ref fDateWorked, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"time_batch_equipReferencesMPetUsers1")]
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
        [Association(@"time_batch_equipReferencesMPetUsers2")]
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
        decimal fhours_worked;
        public decimal hours_worked
        {
            get { return fhours_worked; }
            set { SetPropertyValue<decimal>("hours_worked", ref fhours_worked, value); }
        }
    }

}