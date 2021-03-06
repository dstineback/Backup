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

    public partial class TemplateFormRights : XPLiteObject
    {
        int fRecordID;
        [Key(true)]
        public int RecordID
        {
            get { return fRecordID; }
            set { SetPropertyValue<int>("RecordID", ref fRecordID, value); }
        }
        UserRightTemplates fTemplateID;
        [Association(@"TemplateFormRightsReferencesUserRightTemplates")]
        public UserRightTemplates TemplateID
        {
            get { return fTemplateID; }
            set { SetPropertyValue<UserRightTemplates>("TemplateID", ref fTemplateID, value); }
        }
        MPETForms fFormID;
        [Association(@"TemplateFormRightsReferencesMPETForms")]
        public MPETForms FormID
        {
            get { return fFormID; }
            set { SetPropertyValue<MPETForms>("FormID", ref fFormID, value); }
        }
        int fCanView;
        public int CanView
        {
            get { return fCanView; }
            set { SetPropertyValue<int>("CanView", ref fCanView, value); }
        }
        int fCanAdd;
        public int CanAdd
        {
            get { return fCanAdd; }
            set { SetPropertyValue<int>("CanAdd", ref fCanAdd, value); }
        }
        int fCanEdit;
        public int CanEdit
        {
            get { return fCanEdit; }
            set { SetPropertyValue<int>("CanEdit", ref fCanEdit, value); }
        }
        int fCanDelete;
        public int CanDelete
        {
            get { return fCanDelete; }
            set { SetPropertyValue<int>("CanDelete", ref fCanDelete, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"TemplateFormRightsReferencesMPetUsers")]
        public MPetUsers CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<MPetUsers>("CreatedBy", ref fCreatedBy, value); }
        }
        DateTime fDateCreated;
        public DateTime DateCreated
        {
            get { return fDateCreated; }
            set { SetPropertyValue<DateTime>("DateCreated", ref fDateCreated, value); }
        }
        MPetUsers fModifiedBy;
        [Association(@"TemplateFormRightsReferencesMPetUsers1")]
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
    }

}
