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

    public partial class ProjectConditions : XPLiteObject
    {
        int fn_ProjectConditionID;
        [Key(true)]
        public int n_ProjectConditionID
        {
            get { return fn_ProjectConditionID; }
            set { SetPropertyValue<int>("n_ProjectConditionID", ref fn_ProjectConditionID, value); }
        }
        string fProjectConditionID;
        [Size(20)]
        public string ProjectConditionID
        {
            get { return fProjectConditionID; }
            set { SetPropertyValue<string>("ProjectConditionID", ref fProjectConditionID, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"ProjectConditionsReferencesMPetUsers")]
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
        [Association(@"ProjectConditionsReferencesMPetUsers1")]
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
        [Association(@"ProjectDiaryReferencesProjectConditions", typeof(ProjectDiary))]
        public XPCollection<ProjectDiary> ProjectDiaries { get { return GetCollection<ProjectDiary>("ProjectDiaries"); } }
    }

}
