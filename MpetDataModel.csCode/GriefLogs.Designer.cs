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

    public partial class GriefLogs : XPLiteObject
    {
        int fn_GriefLogID;
        [Key(true)]
        public int n_GriefLogID
        {
            get { return fn_GriefLogID; }
            set { SetPropertyValue<int>("n_GriefLogID", ref fn_GriefLogID, value); }
        }
        string fGriefLogID;
        [Size(10)]
        public string GriefLogID
        {
            get { return fGriefLogID; }
            set { SetPropertyValue<string>("GriefLogID", ref fGriefLogID, value); }
        }
        string fPartID;
        [Size(50)]
        public string PartID
        {
            get { return fPartID; }
            set { SetPropertyValue<string>("PartID", ref fPartID, value); }
        }
        string fPartDescription;
        [Size(254)]
        public string PartDescription
        {
            get { return fPartDescription; }
            set { SetPropertyValue<string>("PartDescription", ref fPartDescription, value); }
        }
        string fProblemDescr;
        [Size(254)]
        public string ProblemDescr
        {
            get { return fProblemDescr; }
            set { SetPropertyValue<string>("ProblemDescr", ref fProblemDescr, value); }
        }
        decimal fQty;
        public decimal Qty
        {
            get { return fQty; }
            set { SetPropertyValue<decimal>("Qty", ref fQty, value); }
        }
        string fUnits;
        [Size(24)]
        public string Units
        {
            get { return fUnits; }
            set { SetPropertyValue<string>("Units", ref fUnits, value); }
        }
        string fPONumber;
        [Size(24)]
        public string PONumber
        {
            get { return fPONumber; }
            set { SetPropertyValue<string>("PONumber", ref fPONumber, value); }
        }
        purchaseorders fn_PONumber;
        [Association(@"GriefLogsReferencespurchaseorders")]
        public purchaseorders n_PONumber
        {
            get { return fn_PONumber; }
            set { SetPropertyValue<purchaseorders>("n_PONumber", ref fn_PONumber, value); }
        }
        string fVendorID;
        [Size(10)]
        public string VendorID
        {
            get { return fVendorID; }
            set { SetPropertyValue<string>("VendorID", ref fVendorID, value); }
        }
        Vendors fn_VendorID;
        [Association(@"GriefLogsReferencesVendors")]
        public Vendors n_VendorID
        {
            get { return fn_VendorID; }
            set { SetPropertyValue<Vendors>("n_VendorID", ref fn_VendorID, value); }
        }
        MPetUsers fn_OriginatorID;
        [Association(@"GriefLogsReferencesMPetUsers2")]
        public MPetUsers n_OriginatorID
        {
            get { return fn_OriginatorID; }
            set { SetPropertyValue<MPetUsers>("n_OriginatorID", ref fn_OriginatorID, value); }
        }
        MPetUsers fn_BuyerID;
        [Association(@"GriefLogsReferencesMPetUsers3")]
        public MPetUsers n_BuyerID
        {
            get { return fn_BuyerID; }
            set { SetPropertyValue<MPetUsers>("n_BuyerID", ref fn_BuyerID, value); }
        }
        string fNotes;
        [Size(SizeAttribute.Unlimited)]
        public string Notes
        {
            get { return fNotes; }
            set { SetPropertyValue<string>("Notes", ref fNotes, value); }
        }
        GriefLogFaults fn_GriefLogFaultID;
        [Association(@"GriefLogsReferencesGriefLogFaults")]
        public GriefLogFaults n_GriefLogFaultID
        {
            get { return fn_GriefLogFaultID; }
            set { SetPropertyValue<GriefLogFaults>("n_GriefLogFaultID", ref fn_GriefLogFaultID, value); }
        }
        string fB_Closed;
        [Size(1)]
        public string B_Closed
        {
            get { return fB_Closed; }
            set { SetPropertyValue<string>("B_Closed", ref fB_Closed, value); }
        }
        MPetUsers fn_ClosedBy;
        [Association(@"GriefLogsReferencesMPetUsers4")]
        public MPetUsers n_ClosedBy
        {
            get { return fn_ClosedBy; }
            set { SetPropertyValue<MPetUsers>("n_ClosedBy", ref fn_ClosedBy, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"GriefLogsReferencesMPetUsers")]
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
        DateTime fResolutionDate;
        public DateTime ResolutionDate
        {
            get { return fResolutionDate; }
            set { SetPropertyValue<DateTime>("ResolutionDate", ref fResolutionDate, value); }
        }
        DateTime fDateClosed;
        public DateTime DateClosed
        {
            get { return fDateClosed; }
            set { SetPropertyValue<DateTime>("DateClosed", ref fDateClosed, value); }
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
        MPetUsers fModifiedBy;
        [Association(@"GriefLogsReferencesMPetUsers1")]
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
        UnitsOfIssue fn_UnitsOfIssueID;
        [Association(@"GriefLogsReferencesUnitsOfIssue")]
        public UnitsOfIssue n_UnitsOfIssueID
        {
            get { return fn_UnitsOfIssueID; }
            set { SetPropertyValue<UnitsOfIssue>("n_UnitsOfIssueID", ref fn_UnitsOfIssueID, value); }
        }
        string fnotesHistory;
        [Size(SizeAttribute.Unlimited)]
        public string notesHistory
        {
            get { return fnotesHistory; }
            set { SetPropertyValue<string>("notesHistory", ref fnotesHistory, value); }
        }
        [Association(@"UsersFlaggedRecordsReferencesGriefLogs", typeof(UsersFlaggedRecords))]
        public XPCollection<UsersFlaggedRecords> UsersFlaggedRecordsCollection { get { return GetCollection<UsersFlaggedRecords>("UsersFlaggedRecordsCollection"); } }
    }

}