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

    public partial class UserFilters : XPLiteObject
    {
        int fRecordID;
        [Key(true)]
        public int RecordID
        {
            get { return fRecordID; }
            set { SetPropertyValue<int>("RecordID", ref fRecordID, value); }
        }
        MPetUsers fUserID;
        [Association(@"UserFiltersReferencesMPetUsers2")]
        public MPetUsers UserID
        {
            get { return fUserID; }
            set { SetPropertyValue<MPetUsers>("UserID", ref fUserID, value); }
        }
        int fFormID;
        public int FormID
        {
            get { return fFormID; }
            set { SetPropertyValue<int>("FormID", ref fFormID, value); }
        }
        string fGridID;
        [Size(50)]
        public string GridID
        {
            get { return fGridID; }
            set { SetPropertyValue<string>("GridID", ref fGridID, value); }
        }
        string fFilterName;
        [Size(30)]
        public string FilterName
        {
            get { return fFilterName; }
            set { SetPropertyValue<string>("FilterName", ref fFilterName, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        string fFilterText;
        [Size(SizeAttribute.Unlimited)]
        public string FilterText
        {
            get { return fFilterText; }
            set { SetPropertyValue<string>("FilterText", ref fFilterText, value); }
        }
        string fColumnOrder;
        [Size(SizeAttribute.Unlimited)]
        public string ColumnOrder
        {
            get { return fColumnOrder; }
            set { SetPropertyValue<string>("ColumnOrder", ref fColumnOrder, value); }
        }
        string fPinnedRows;
        [Size(SizeAttribute.Unlimited)]
        public string PinnedRows
        {
            get { return fPinnedRows; }
            set { SetPropertyValue<string>("PinnedRows", ref fPinnedRows, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"UserFiltersReferencesMPetUsers")]
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
        [Association(@"UserFiltersReferencesMPetUsers1")]
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
    }

}
