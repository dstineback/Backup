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

    [NonPersistent]
    public partial class filter_GetFilteredStoresIssueListResult
    {
        public int n_StoresIssueID { get; set; }
        public string StoresIssueID { get; set; }
        public string b_Approved { get; set; }
        public string b_Closed { get; set; }
        public int n_StoreRoomID { get; set; }
        public int n_Requestor { get; set; }
        public string RequestorID { get; set; }
        public int n_ApprovedBy { get; set; }
        public int n_CheckOutID { get; set; }
        public int n_chkoutreasonid { get; set; }
        public DateTime NeededByDate { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string Status { get; set; }
        public int n_StatusBy { get; set; }
        public DateTime StatusDate { get; set; }
        public string OrigStoresIssueID { get; set; }
        public int n_AreaID { get; set; }
        public int n_costcodeid { get; set; }
        public string costcodeid { get; set; }
        public string SupplementalCode { get; set; }
        public string Approver { get; set; }
        public string CostCodeDesc { get; set; }
        public string FundSrcCodeID { get; set; }
        public string WorkOrderCodeID { get; set; }
        public string WorkOpID { get; set; }
        public string OrganizationCodeID { get; set; }
        public string FundingGroupCodeID { get; set; }
        public string ControlSectionID { get; set; }
        public string EquipmentNumberID { get; set; }
        public int FlaggedRecordID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }

}
