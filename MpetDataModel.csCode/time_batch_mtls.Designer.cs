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

    public partial class time_batch_mtls : XPLiteObject
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
        [Association(@"time_batch_mtlsReferencestime_batches")]
        public time_batches n_time_batchid
        {
            get { return fn_time_batchid; }
            set { SetPropertyValue<time_batches>("n_time_batchid", ref fn_time_batchid, value); }
        }
        Storerooms fn_storeroomid;
        [Association(@"time_batch_mtlsReferencesStorerooms")]
        public Storerooms n_storeroomid
        {
            get { return fn_storeroomid; }
            set { SetPropertyValue<Storerooms>("n_storeroomid", ref fn_storeroomid, value); }
        }
        Masterparts fn_masterpartid;
        [Association(@"time_batch_mtlsReferencesMasterparts")]
        public Masterparts n_masterpartid
        {
            get { return fn_masterpartid; }
            set { SetPropertyValue<Masterparts>("n_masterpartid", ref fn_masterpartid, value); }
        }
        JobParts fn_jobpartid;
        [Association(@"time_batch_mtlsReferencesJobParts")]
        public JobParts n_jobpartid
        {
            get { return fn_jobpartid; }
            set { SetPropertyValue<JobParts>("n_jobpartid", ref fn_jobpartid, value); }
        }
        string fMTLUnits;
        [Size(25)]
        public string MTLUnits
        {
            get { return fMTLUnits; }
            set { SetPropertyValue<string>("MTLUnits", ref fMTLUnits, value); }
        }
        decimal fQty_Used;
        public decimal Qty_Used
        {
            get { return fQty_Used; }
            set { SetPropertyValue<decimal>("Qty_Used", ref fQty_Used, value); }
        }
        string fUnits;
        [Size(25)]
        public string Units
        {
            get { return fUnits; }
            set { SetPropertyValue<string>("Units", ref fUnits, value); }
        }
        DateTime fDateWorked;
        public DateTime DateWorked
        {
            get { return fDateWorked; }
            set { SetPropertyValue<DateTime>("DateWorked", ref fDateWorked, value); }
        }
        PartsAtLocation fn_partatlocid;
        [Association(@"time_batch_mtlsReferencesPartsAtLocation")]
        public PartsAtLocation n_partatlocid
        {
            get { return fn_partatlocid; }
            set { SetPropertyValue<PartsAtLocation>("n_partatlocid", ref fn_partatlocid, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"time_batch_mtlsReferencesMPetUsers")]
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
        [Association(@"time_batch_mtlsReferencesMPetUsers1")]
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