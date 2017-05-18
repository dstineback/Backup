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

    public partial class IncidentResponses : XPLiteObject
    {
        int fn_IncidentResponseID;
        [Key(true)]
        public int n_IncidentResponseID
        {
            get { return fn_IncidentResponseID; }
            set { SetPropertyValue<int>("n_IncidentResponseID", ref fn_IncidentResponseID, value); }
        }
        string fIncidentResponseID;
        [Size(20)]
        public string IncidentResponseID
        {
            get { return fIncidentResponseID; }
            set { SetPropertyValue<string>("IncidentResponseID", ref fIncidentResponseID, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"IncidentResponsesReferencesMPetUsers")]
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
        [Association(@"IncidentResponsesReferencesMPetUsers1")]
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
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        [Association(@"IncidentsReferencesIncidentResponses", typeof(Incidents))]
        public XPCollection<Incidents> IncidentsCollection { get { return GetCollection<Incidents>("IncidentsCollection"); } }
    }

}