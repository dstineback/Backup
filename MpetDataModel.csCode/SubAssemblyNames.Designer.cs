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

    public partial class SubAssemblyNames : XPLiteObject
    {
        int fnSubAssemblyID;
        [Key(true)]
        public int nSubAssemblyID
        {
            get { return fnSubAssemblyID; }
            set { SetPropertyValue<int>("nSubAssemblyID", ref fnSubAssemblyID, value); }
        }
        string fSubAssemblyName;
        [Size(50)]
        public string SubAssemblyName
        {
            get { return fSubAssemblyName; }
            set { SetPropertyValue<string>("SubAssemblyName", ref fSubAssemblyName, value); }
        }
        string fSubAssemblyDesc;
        [Size(254)]
        public string SubAssemblyDesc
        {
            get { return fSubAssemblyDesc; }
            set { SetPropertyValue<string>("SubAssemblyDesc", ref fSubAssemblyDesc, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"SubAssemblyNamesReferencesMPetUsers")]
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
        [Association(@"SubAssemblyNamesReferencesMPetUsers1")]
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
        [Association(@"FieldDataCollectionReferencesSubAssemblyNames", typeof(FieldDataCollection))]
        public XPCollection<FieldDataCollection> FieldDataCollections { get { return GetCollection<FieldDataCollection>("FieldDataCollections"); } }
        [Association(@"JobsReferencesSubAssemblyNames", typeof(Jobs))]
        public XPCollection<Jobs> JobsCollection { get { return GetCollection<Jobs>("JobsCollection"); } }
        [Association(@"JobstepsReferencesSubAssemblyNames", typeof(Jobsteps))]
        public XPCollection<Jobsteps> JobstepsCollection { get { return GetCollection<Jobsteps>("JobstepsCollection"); } }
        [Association(@"ObjectTasksReferencesSubAssemblyNames", typeof(ObjectTasks))]
        public XPCollection<ObjectTasks> ObjectTasksCollection { get { return GetCollection<ObjectTasks>("ObjectTasksCollection"); } }
    }

}