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

    public partial class ShippingReturnReasons : XPLiteObject
    {
        int fn_ReturnReasonID;
        [Key(true)]
        public int n_ReturnReasonID
        {
            get { return fn_ReturnReasonID; }
            set { SetPropertyValue<int>("n_ReturnReasonID", ref fn_ReturnReasonID, value); }
        }
        string fReturnReasonID;
        [Size(20)]
        public string ReturnReasonID
        {
            get { return fReturnReasonID; }
            set { SetPropertyValue<string>("ReturnReasonID", ref fReturnReasonID, value); }
        }
        string fdescription;
        [Size(254)]
        public string description
        {
            get { return fdescription; }
            set { SetPropertyValue<string>("description", ref fdescription, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"ShippingReturnReasonsReferencesMPetUsers")]
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
        [Association(@"ShippingReturnReasonsReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fLastModified;
        public DateTime LastModified
        {
            get { return fLastModified; }
            set { SetPropertyValue<DateTime>("LastModified", ref fLastModified, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        [Association(@"ShippingReportsReferencesShippingReturnReasons", typeof(ShippingReports))]
        public XPCollection<ShippingReports> ShippingReportsCollection { get { return GetCollection<ShippingReports>("ShippingReportsCollection"); } }
    }

}