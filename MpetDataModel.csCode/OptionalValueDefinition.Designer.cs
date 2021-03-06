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

    public partial class OptionalValueDefinition : XPLiteObject
    {
        int fRecordID;
        [Key(true)]
        public int RecordID
        {
            get { return fRecordID; }
            set { SetPropertyValue<int>("RecordID", ref fRecordID, value); }
        }
        int fFormID;
        public int FormID
        {
            get { return fFormID; }
            set { SetPropertyValue<int>("FormID", ref fFormID, value); }
        }
        string fUserPrompt;
        [Size(254)]
        public string UserPrompt
        {
            get { return fUserPrompt; }
            set { SetPropertyValue<string>("UserPrompt", ref fUserPrompt, value); }
        }
        string fRequired;
        [Size(1)]
        public string Required
        {
            get { return fRequired; }
            set { SetPropertyValue<string>("Required", ref fRequired, value); }
        }
        int fDisplayTab;
        public int DisplayTab
        {
            get { return fDisplayTab; }
            set { SetPropertyValue<int>("DisplayTab", ref fDisplayTab, value); }
        }
        int fDisplayOrder;
        public int DisplayOrder
        {
            get { return fDisplayOrder; }
            set { SetPropertyValue<int>("DisplayOrder", ref fDisplayOrder, value); }
        }
        int fDataType;
        public int DataType
        {
            get { return fDataType; }
            set { SetPropertyValue<int>("DataType", ref fDataType, value); }
        }
        string fActive;
        [Size(1)]
        public string Active
        {
            get { return fActive; }
            set { SetPropertyValue<string>("Active", ref fActive, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"OptionalValueDefinitionReferencesMPetUsers")]
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
        [Association(@"OptionalValueDefinitionReferencesMPetUsers1")]
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
