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

    public partial class UserEmailAddresses : XPLiteObject
    {
        int fEmailID;
        [Key(true)]
        public int EmailID
        {
            get { return fEmailID; }
            set { SetPropertyValue<int>("EmailID", ref fEmailID, value); }
        }
        MPetUsers fUserID;
        [Association(@"UserEmailAddressesReferencesMPetUsers2")]
        public MPetUsers UserID
        {
            get { return fUserID; }
            set { SetPropertyValue<MPetUsers>("UserID", ref fUserID, value); }
        }
        string fEmailAddress;
        public string EmailAddress
        {
            get { return fEmailAddress; }
            set { SetPropertyValue<string>("EmailAddress", ref fEmailAddress, value); }
        }
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        int fActive;
        public int Active
        {
            get { return fActive; }
            set { SetPropertyValue<int>("Active", ref fActive, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"UserEmailAddressesReferencesMPetUsers")]
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
        [Association(@"UserEmailAddressesReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fLast_modified;
        public DateTime Last_modified
        {
            get { return fLast_modified; }
            set { SetPropertyValue<DateTime>("Last_modified", ref fLast_modified, value); }
        }
        int fb_EmailRequestReceipts;
        public int b_EmailRequestReceipts
        {
            get { return fb_EmailRequestReceipts; }
            set { SetPropertyValue<int>("b_EmailRequestReceipts", ref fb_EmailRequestReceipts, value); }
        }
        int fb_EmailRequestStatusUpdates;
        public int b_EmailRequestStatusUpdates
        {
            get { return fb_EmailRequestStatusUpdates; }
            set { SetPropertyValue<int>("b_EmailRequestStatusUpdates", ref fb_EmailRequestStatusUpdates, value); }
        }
        int fb_EmailRequestPriorityUpdates;
        public int b_EmailRequestPriorityUpdates
        {
            get { return fb_EmailRequestPriorityUpdates; }
            set { SetPropertyValue<int>("b_EmailRequestPriorityUpdates", ref fb_EmailRequestPriorityUpdates, value); }
        }
        int fb_EmailPlannedStatusUpdates;
        public int b_EmailPlannedStatusUpdates
        {
            get { return fb_EmailPlannedStatusUpdates; }
            set { SetPropertyValue<int>("b_EmailPlannedStatusUpdates", ref fb_EmailPlannedStatusUpdates, value); }
        }
        int fb_EmailPlannedPriorityUpdates;
        public int b_EmailPlannedPriorityUpdates
        {
            get { return fb_EmailPlannedPriorityUpdates; }
            set { SetPropertyValue<int>("b_EmailPlannedPriorityUpdates", ref fb_EmailPlannedPriorityUpdates, value); }
        }
        int fb_EmailPlannedScheduledDateUpdates;
        public int b_EmailPlannedScheduledDateUpdates
        {
            get { return fb_EmailPlannedScheduledDateUpdates; }
            set { SetPropertyValue<int>("b_EmailPlannedScheduledDateUpdates", ref fb_EmailPlannedScheduledDateUpdates, value); }
        }
        int fb_EmailJobPostedToHistory;
        public int b_EmailJobPostedToHistory
        {
            get { return fb_EmailJobPostedToHistory; }
            set { SetPropertyValue<int>("b_EmailJobPostedToHistory", ref fb_EmailJobPostedToHistory, value); }
        }
        int fb_EmailRequisitionReceipt;
        public int b_EmailRequisitionReceipt
        {
            get { return fb_EmailRequisitionReceipt; }
            set { SetPropertyValue<int>("b_EmailRequisitionReceipt", ref fb_EmailRequisitionReceipt, value); }
        }
        int fb_EmailRequisitionStatusUpdates;
        public int b_EmailRequisitionStatusUpdates
        {
            get { return fb_EmailRequisitionStatusUpdates; }
            set { SetPropertyValue<int>("b_EmailRequisitionStatusUpdates", ref fb_EmailRequisitionStatusUpdates, value); }
        }
        int fb_EmailRequisitionAddedToPO;
        public int b_EmailRequisitionAddedToPO
        {
            get { return fb_EmailRequisitionAddedToPO; }
            set { SetPropertyValue<int>("b_EmailRequisitionAddedToPO", ref fb_EmailRequisitionAddedToPO, value); }
        }
        int fb_EmailPOStatusUpdate;
        public int b_EmailPOStatusUpdate
        {
            get { return fb_EmailPOStatusUpdate; }
            set { SetPropertyValue<int>("b_EmailPOStatusUpdate", ref fb_EmailPOStatusUpdate, value); }
        }
        int fb_EmailRequisitionReceived;
        public int b_EmailRequisitionReceived
        {
            get { return fb_EmailRequisitionReceived; }
            set { SetPropertyValue<int>("b_EmailRequisitionReceived", ref fb_EmailRequisitionReceived, value); }
        }
    }

}