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

    public partial class PurchaseOrderAlertDefaults : XPLiteObject
    {
        int fAlertID;
        [Key(true)]
        public int AlertID
        {
            get { return fAlertID; }
            set { SetPropertyValue<int>("AlertID", ref fAlertID, value); }
        }
        int fAlertType;
        public int AlertType
        {
            get { return fAlertType; }
            set { SetPropertyValue<int>("AlertType", ref fAlertType, value); }
        }
        int fAlertLevel;
        public int AlertLevel
        {
            get { return fAlertLevel; }
            set { SetPropertyValue<int>("AlertLevel", ref fAlertLevel, value); }
        }
        int fActive;
        public int Active
        {
            get { return fActive; }
            set { SetPropertyValue<int>("Active", ref fActive, value); }
        }
        int fDaysLate;
        public int DaysLate
        {
            get { return fDaysLate; }
            set { SetPropertyValue<int>("DaysLate", ref fDaysLate, value); }
        }
        int fForegroundColor;
        public int ForegroundColor
        {
            get { return fForegroundColor; }
            set { SetPropertyValue<int>("ForegroundColor", ref fForegroundColor, value); }
        }
        int fBackgroundColor;
        public int BackgroundColor
        {
            get { return fBackgroundColor; }
            set { SetPropertyValue<int>("BackgroundColor", ref fBackgroundColor, value); }
        }
        string fSendEmail;
        [Size(1)]
        public string SendEmail
        {
            get { return fSendEmail; }
            set { SetPropertyValue<string>("SendEmail", ref fSendEmail, value); }
        }
        string fApplyDaysBefore;
        [Size(1)]
        public string ApplyDaysBefore
        {
            get { return fApplyDaysBefore; }
            set { SetPropertyValue<string>("ApplyDaysBefore", ref fApplyDaysBefore, value); }
        }
        int fEmailID;
        public int EmailID
        {
            get { return fEmailID; }
            set { SetPropertyValue<int>("EmailID", ref fEmailID, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"PurchaseOrderAlertDefaultsReferencesMPetUsers")]
        public MPetUsers CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<MPetUsers>("CreatedBy", ref fCreatedBy, value); }
        }
        MPetUsers fModifiedBy;
        [Association(@"PurchaseOrderAlertDefaultsReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        DateTime fLastModified;
        public DateTime LastModified
        {
            get { return fLastModified; }
            set { SetPropertyValue<DateTime>("LastModified", ref fLastModified, value); }
        }
    }

}
