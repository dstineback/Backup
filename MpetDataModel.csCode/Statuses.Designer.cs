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

    public partial class Statuses : XPLiteObject
    {
        int fnStatusID;
        [Key(true)]
        public int nStatusID
        {
            get { return fnStatusID; }
            set { SetPropertyValue<int>("nStatusID", ref fnStatusID, value); }
        }
        string fStatusID;
        [Size(50)]
        public string StatusID
        {
            get { return fStatusID; }
            set { SetPropertyValue<string>("StatusID", ref fStatusID, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        char fSuspended;
        public char Suspended
        {
            get { return fSuspended; }
            set { SetPropertyValue<char>("Suspended", ref fSuspended, value); }
        }
        char fSystem;
        public char System
        {
            get { return fSystem; }
            set { SetPropertyValue<char>("System", ref fSystem, value); }
        }
        int fiStage;
        public int iStage
        {
            get { return fiStage; }
            set { SetPropertyValue<int>("iStage", ref fiStage, value); }
        }
        string fszStage;
        [Size(10)]
        public string szStage
        {
            get { return fszStage; }
            set { SetPropertyValue<string>("szStage", ref fszStage, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"StatusesReferencesMPetUsers")]
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
        MPetUsers fLastModifiedBy;
        [Association(@"StatusesReferencesMPetUsers1")]
        public MPetUsers LastModifiedBy
        {
            get { return fLastModifiedBy; }
            set { SetPropertyValue<MPetUsers>("LastModifiedBy", ref fLastModifiedBy, value); }
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
        [Association(@"JobstepsReferencesStatuses", typeof(Jobsteps))]
        public XPCollection<Jobsteps> JobstepsCollection { get { return GetCollection<Jobsteps>("JobstepsCollection"); } }
    }

}