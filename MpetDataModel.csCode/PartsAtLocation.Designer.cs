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

    public partial class PartsAtLocation : XPLiteObject
    {
        int fn_partatlocid;
        [Key(true)]
        public int n_partatlocid
        {
            get { return fn_partatlocid; }
            set { SetPropertyValue<int>("n_partatlocid", ref fn_partatlocid, value); }
        }
        Storerooms fn_storeroomid;
        [Association(@"PartsAtLocationReferencesStorerooms")]
        public Storerooms n_storeroomid
        {
            get { return fn_storeroomid; }
            set { SetPropertyValue<Storerooms>("n_storeroomid", ref fn_storeroomid, value); }
        }
        Masterparts fn_masterpartid;
        [Association(@"PartsAtLocationReferencesMasterparts")]
        public Masterparts n_masterpartid
        {
            get { return fn_masterpartid; }
            set { SetPropertyValue<Masterparts>("n_masterpartid", ref fn_masterpartid, value); }
        }
        string faisle;
        [Size(10)]
        public string aisle
        {
            get { return faisle; }
            set { SetPropertyValue<string>("aisle", ref faisle, value); }
        }
        string fbin;
        [Size(10)]
        public string bin
        {
            get { return fbin; }
            set { SetPropertyValue<string>("bin", ref fbin, value); }
        }
        int fdemand;
        public int demand
        {
            get { return fdemand; }
            set { SetPropertyValue<int>("demand", ref fdemand, value); }
        }
        int fIntLeadTime;
        public int IntLeadTime
        {
            get { return fIntLeadTime; }
            set { SetPropertyValue<int>("IntLeadTime", ref fIntLeadTime, value); }
        }
        DateTime flastcountdate;
        public DateTime lastcountdate
        {
            get { return flastcountdate; }
            set { SetPropertyValue<DateTime>("lastcountdate", ref flastcountdate, value); }
        }
        int fLastCountQty;
        public int LastCountQty
        {
            get { return fLastCountQty; }
            set { SetPropertyValue<int>("LastCountQty", ref fLastCountQty, value); }
        }
        DateTime fLastAdjustDate;
        public DateTime LastAdjustDate
        {
            get { return fLastAdjustDate; }
            set { SetPropertyValue<DateTime>("LastAdjustDate", ref fLastAdjustDate, value); }
        }
        int fMaxQty;
        public int MaxQty
        {
            get { return fMaxQty; }
            set { SetPropertyValue<int>("MaxQty", ref fMaxQty, value); }
        }
        int fqtyonhand;
        public int qtyonhand
        {
            get { return fqtyonhand; }
            set { SetPropertyValue<int>("qtyonhand", ref fqtyonhand, value); }
        }
        int freorderpt;
        public int reorderpt
        {
            get { return freorderpt; }
            set { SetPropertyValue<int>("reorderpt", ref freorderpt, value); }
        }
        int freorderqty;
        public int reorderqty
        {
            get { return freorderqty; }
            set { SetPropertyValue<int>("reorderqty", ref freorderqty, value); }
        }
        int fSafetyStock;
        public int SafetyStock
        {
            get { return fSafetyStock; }
            set { SetPropertyValue<int>("SafetyStock", ref fSafetyStock, value); }
        }
        string fshelf;
        [Size(10)]
        public string shelf
        {
            get { return fshelf; }
            set { SetPropertyValue<string>("shelf", ref fshelf, value); }
        }
        int fpending_delete;
        public int pending_delete
        {
            get { return fpending_delete; }
            set { SetPropertyValue<int>("pending_delete", ref fpending_delete, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"PartsAtLocationReferencesMPetUsers")]
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
        [Association(@"PartsAtLocationReferencesMPetUsers1")]
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
        string fMRPRuleType;
        [Size(25)]
        public string MRPRuleType
        {
            get { return fMRPRuleType; }
            set { SetPropertyValue<string>("MRPRuleType", ref fMRPRuleType, value); }
        }
        [Association(@"CycleCountsReferencesPartsAtLocation", typeof(CycleCounts))]
        public XPCollection<CycleCounts> CycleCountsCollection { get { return GetCollection<CycleCounts>("CycleCountsCollection"); } }
        [Association(@"JobPartsReferencesPartsAtLocation", typeof(JobParts))]
        public XPCollection<JobParts> JobPartsCollection { get { return GetCollection<JobParts>("JobPartsCollection"); } }
        [Association(@"time_batch_mtlsReferencesPartsAtLocation", typeof(time_batch_mtls))]
        public XPCollection<time_batch_mtls> time_batch_mtlss { get { return GetCollection<time_batch_mtls>("time_batch_mtlss"); } }
        [Association(@"xactionitemsReferencesPartsAtLocation", typeof(xactionitems))]
        public XPCollection<xactionitems> xactionitemsCollection { get { return GetCollection<xactionitems>("xactionitemsCollection"); } }
    }

}
