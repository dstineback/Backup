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

    public partial class StoresIssues : XPLiteObject
    {
        int fn_StoresIssueID;
        [Key(true)]
        public int n_StoresIssueID
        {
            get { return fn_StoresIssueID; }
            set { SetPropertyValue<int>("n_StoresIssueID", ref fn_StoresIssueID, value); }
        }
        string fStoresIssueID;
        [Size(10)]
        public string StoresIssueID
        {
            get { return fStoresIssueID; }
            set { SetPropertyValue<string>("StoresIssueID", ref fStoresIssueID, value); }
        }
        string fb_Approved;
        [Size(1)]
        public string b_Approved
        {
            get { return fb_Approved; }
            set { SetPropertyValue<string>("b_Approved", ref fb_Approved, value); }
        }
        string fb_Closed;
        [Size(1)]
        public string b_Closed
        {
            get { return fb_Closed; }
            set { SetPropertyValue<string>("b_Closed", ref fb_Closed, value); }
        }
        Storerooms fn_StoreRoomID;
        [Association(@"StoresIssuesReferencesStorerooms")]
        public Storerooms n_StoreRoomID
        {
            get { return fn_StoreRoomID; }
            set { SetPropertyValue<Storerooms>("n_StoreRoomID", ref fn_StoreRoomID, value); }
        }
        MPetUsers fn_Requestor;
        [Association(@"StoresIssuesReferencesMPetUsers3")]
        public MPetUsers n_Requestor
        {
            get { return fn_Requestor; }
            set { SetPropertyValue<MPetUsers>("n_Requestor", ref fn_Requestor, value); }
        }
        MPetUsers fn_ApprovedBy;
        [Association(@"StoresIssuesReferencesMPetUsers")]
        public MPetUsers n_ApprovedBy
        {
            get { return fn_ApprovedBy; }
            set { SetPropertyValue<MPetUsers>("n_ApprovedBy", ref fn_ApprovedBy, value); }
        }
        int fn_CheckOutID;
        public int n_CheckOutID
        {
            get { return fn_CheckOutID; }
            set { SetPropertyValue<int>("n_CheckOutID", ref fn_CheckOutID, value); }
        }
        CheckOutReasons fn_chkoutreasonid;
        [Association(@"StoresIssuesReferencesCheckOutReasons")]
        public CheckOutReasons n_chkoutreasonid
        {
            get { return fn_chkoutreasonid; }
            set { SetPropertyValue<CheckOutReasons>("n_chkoutreasonid", ref fn_chkoutreasonid, value); }
        }
        string fDescr;
        [Size(SizeAttribute.Unlimited)]
        public string Descr
        {
            get { return fDescr; }
            set { SetPropertyValue<string>("Descr", ref fDescr, value); }
        }
        DateTime fNeededByDate;
        public DateTime NeededByDate
        {
            get { return fNeededByDate; }
            set { SetPropertyValue<DateTime>("NeededByDate", ref fNeededByDate, value); }
        }
        DateTime fRequestDate;
        public DateTime RequestDate
        {
            get { return fRequestDate; }
            set { SetPropertyValue<DateTime>("RequestDate", ref fRequestDate, value); }
        }
        DateTime fApprovalDate;
        public DateTime ApprovalDate
        {
            get { return fApprovalDate; }
            set { SetPropertyValue<DateTime>("ApprovalDate", ref fApprovalDate, value); }
        }
        string fStatus;
        [Size(25)]
        public string Status
        {
            get { return fStatus; }
            set { SetPropertyValue<string>("Status", ref fStatus, value); }
        }
        MPetUsers fn_StatusBy;
        [Association(@"StoresIssuesReferencesMPetUsers4")]
        public MPetUsers n_StatusBy
        {
            get { return fn_StatusBy; }
            set { SetPropertyValue<MPetUsers>("n_StatusBy", ref fn_StatusBy, value); }
        }
        DateTime fStatusDate;
        public DateTime StatusDate
        {
            get { return fStatusDate; }
            set { SetPropertyValue<DateTime>("StatusDate", ref fStatusDate, value); }
        }
        string fOrigStoresIssueID;
        [Size(10)]
        public string OrigStoresIssueID
        {
            get { return fOrigStoresIssueID; }
            set { SetPropertyValue<string>("OrigStoresIssueID", ref fOrigStoresIssueID, value); }
        }
        Areas fn_AreaID;
        [Association(@"StoresIssuesReferencesAreas")]
        public Areas n_AreaID
        {
            get { return fn_AreaID; }
            set { SetPropertyValue<Areas>("n_AreaID", ref fn_AreaID, value); }
        }
        CostCodes fn_costcodeid;
        [Association(@"StoresIssuesReferencesCostCodes")]
        public CostCodes n_costcodeid
        {
            get { return fn_costcodeid; }
            set { SetPropertyValue<CostCodes>("n_costcodeid", ref fn_costcodeid, value); }
        }
        string fHistoryAuditTrail;
        [Size(SizeAttribute.Unlimited)]
        public string HistoryAuditTrail
        {
            get { return fHistoryAuditTrail; }
            set { SetPropertyValue<string>("HistoryAuditTrail", ref fHistoryAuditTrail, value); }
        }
        string fb_IsCanceled;
        [Size(1)]
        public string b_IsCanceled
        {
            get { return fb_IsCanceled; }
            set { SetPropertyValue<string>("b_IsCanceled", ref fb_IsCanceled, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"StoresIssuesReferencesMPetUsers1")]
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
        [Association(@"StoresIssuesReferencesMPetUsers2")]
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
        FundSrcCodes fn_FundSrcCodeID;
        [Association(@"StoresIssuesReferencesFundSrcCodes")]
        public FundSrcCodes n_FundSrcCodeID
        {
            get { return fn_FundSrcCodeID; }
            set { SetPropertyValue<FundSrcCodes>("n_FundSrcCodeID", ref fn_FundSrcCodeID, value); }
        }
        WorkOrderCodes fn_WorkOrderCodeID;
        [Association(@"StoresIssuesReferencesWorkOrderCodes")]
        public WorkOrderCodes n_WorkOrderCodeID
        {
            get { return fn_WorkOrderCodeID; }
            set { SetPropertyValue<WorkOrderCodes>("n_WorkOrderCodeID", ref fn_WorkOrderCodeID, value); }
        }
        WorkOperations fn_WorkOpID;
        [Association(@"StoresIssuesReferencesWorkOperations")]
        public WorkOperations n_WorkOpID
        {
            get { return fn_WorkOpID; }
            set { SetPropertyValue<WorkOperations>("n_WorkOpID", ref fn_WorkOpID, value); }
        }
        OrganizationCodes fn_OrganizationCodeID;
        [Association(@"StoresIssuesReferencesOrganizationCodes")]
        public OrganizationCodes n_OrganizationCodeID
        {
            get { return fn_OrganizationCodeID; }
            set { SetPropertyValue<OrganizationCodes>("n_OrganizationCodeID", ref fn_OrganizationCodeID, value); }
        }
        FundingGroupCodes fn_FundingGroupCodeID;
        [Association(@"StoresIssuesReferencesFundingGroupCodes")]
        public FundingGroupCodes n_FundingGroupCodeID
        {
            get { return fn_FundingGroupCodeID; }
            set { SetPropertyValue<FundingGroupCodes>("n_FundingGroupCodeID", ref fn_FundingGroupCodeID, value); }
        }
        ControlSections fn_ControlSectionID;
        [Association(@"StoresIssuesReferencesControlSections")]
        public ControlSections n_ControlSectionID
        {
            get { return fn_ControlSectionID; }
            set { SetPropertyValue<ControlSections>("n_ControlSectionID", ref fn_ControlSectionID, value); }
        }
        EquipmentNumber fn_EquipmentNumberID;
        [Association(@"StoresIssuesReferencesEquipmentNumber")]
        public EquipmentNumber n_EquipmentNumberID
        {
            get { return fn_EquipmentNumberID; }
            set { SetPropertyValue<EquipmentNumber>("n_EquipmentNumberID", ref fn_EquipmentNumberID, value); }
        }
        string fnotesHistory;
        [Size(SizeAttribute.Unlimited)]
        public string notesHistory
        {
            get { return fnotesHistory; }
            set { SetPropertyValue<string>("notesHistory", ref fnotesHistory, value); }
        }
        Jobsteps fn_jobstepid;
        [Association(@"StoresIssuesReferencesJobsteps")]
        public Jobsteps n_jobstepid
        {
            get { return fn_jobstepid; }
            set { SetPropertyValue<Jobsteps>("n_jobstepid", ref fn_jobstepid, value); }
        }
        string fb_IsForJob;
        [Size(1)]
        public string b_IsForJob
        {
            get { return fb_IsForJob; }
            set { SetPropertyValue<string>("b_IsForJob", ref fb_IsForJob, value); }
        }
        [Association(@"JobPartsReferencesStoresIssues", typeof(JobParts))]
        public XPCollection<JobParts> JobPartsCollection { get { return GetCollection<JobParts>("JobPartsCollection"); } }
        [Association(@"partxactionsReferencesStoresIssues", typeof(partxactions))]
        public XPCollection<partxactions> partxactionsCollection { get { return GetCollection<partxactions>("partxactionsCollection"); } }
        [Association(@"StoresIssueItemsReferencesStoresIssues", typeof(StoresIssueItems))]
        public XPCollection<StoresIssueItems> StoresIssueItemsCollection { get { return GetCollection<StoresIssueItems>("StoresIssueItemsCollection"); } }
        [Association(@"UsersFlaggedRecordsReferencesStoresIssues", typeof(UsersFlaggedRecords))]
        public XPCollection<UsersFlaggedRecords> UsersFlaggedRecordsCollection { get { return GetCollection<UsersFlaggedRecords>("UsersFlaggedRecordsCollection"); } }
    }

}