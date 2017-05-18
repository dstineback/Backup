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

    public partial class MPETForms : XPLiteObject
    {
        int fFormID;
        [Key(true)]
        public int FormID
        {
            get { return fFormID; }
            set { SetPropertyValue<int>("FormID", ref fFormID, value); }
        }
        string fFormName;
        public string FormName
        {
            get { return fFormName; }
            set { SetPropertyValue<string>("FormName", ref fFormName, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        MPetUsers fAddedBy;
        [Association(@"MPETFormsReferencesMPetUsers")]
        public MPetUsers AddedBy
        {
            get { return fAddedBy; }
            set { SetPropertyValue<MPetUsers>("AddedBy", ref fAddedBy, value); }
        }
        DateTime fAddedOn;
        public DateTime AddedOn
        {
            get { return fAddedOn; }
            set { SetPropertyValue<DateTime>("AddedOn", ref fAddedOn, value); }
        }
        MPetUsers fModifiedBy;
        [Association(@"MPETFormsReferencesMPetUsers1")]
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
        [Association(@"TemplateFormRightsReferencesMPETForms", typeof(TemplateFormRights))]
        public XPCollection<TemplateFormRights> TemplateFormRightsCollection { get { return GetCollection<TemplateFormRights>("TemplateFormRightsCollection"); } }
    }

}
