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

    public partial class ProjectDiaryItemPersonnel : XPLiteObject
    {
        int fRecordID;
        [Key(true)]
        public int RecordID
        {
            get { return fRecordID; }
            set { SetPropertyValue<int>("RecordID", ref fRecordID, value); }
        }
        ProjectDiary fn_ProjectDiaryID;
        [Association(@"ProjectDiaryItemPersonnelReferencesProjectDiary")]
        public ProjectDiary n_ProjectDiaryID
        {
            get { return fn_ProjectDiaryID; }
            set { SetPropertyValue<ProjectDiary>("n_ProjectDiaryID", ref fn_ProjectDiaryID, value); }
        }
        ProjectDiaryItems fn_ProjectDiaryItemId;
        [Association(@"ProjectDiaryItemPersonnelReferencesProjectDiaryItems")]
        public ProjectDiaryItems n_ProjectDiaryItemId
        {
            get { return fn_ProjectDiaryItemId; }
            set { SetPropertyValue<ProjectDiaryItems>("n_ProjectDiaryItemId", ref fn_ProjectDiaryItemId, value); }
        }
        string fName;
        [Size(50)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
        string fLaborClass;
        [Size(20)]
        public string LaborClass
        {
            get { return fLaborClass; }
            set { SetPropertyValue<string>("LaborClass", ref fLaborClass, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"ProjectDiaryItemPersonnelReferencesMPetUsers")]
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
        [Association(@"ProjectDiaryItemPersonnelReferencesMPetUsers1")]
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
