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

    public partial class objectclasses : XPLiteObject
    {
        int fn_objclassid;
        [Key(true)]
        public int n_objclassid
        {
            get { return fn_objclassid; }
            set { SetPropertyValue<int>("n_objclassid", ref fn_objclassid, value); }
        }
        string fobjclassid;
        [Size(10)]
        public string objclassid
        {
            get { return fobjclassid; }
            set { SetPropertyValue<string>("objclassid", ref fobjclassid, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        Tasks ftasknum;
        [Association(@"objectclassesReferencesTasks")]
        public Tasks tasknum
        {
            get { return ftasknum; }
            set { SetPropertyValue<Tasks>("tasknum", ref ftasknum, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"objectclassesReferencesMPetUsers")]
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
        [Association(@"objectclassesReferencesMPetUsers1")]
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
        [Association(@"MaintenanceObjectsReferencesobjectclasses", typeof(MaintenanceObjects))]
        public XPCollection<MaintenanceObjects> MaintenanceObjectsCollection { get { return GetCollection<MaintenanceObjects>("MaintenanceObjectsCollection"); } }
    }

}
