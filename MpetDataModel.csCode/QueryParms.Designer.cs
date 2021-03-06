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

    public partial class QueryParms : XPLiteObject
    {
        int fRecordID;
        [Key(true)]
        public int RecordID
        {
            get { return fRecordID; }
            set { SetPropertyValue<int>("RecordID", ref fRecordID, value); }
        }
        StoredProcsAndQueries fStoredProcOrQueryID;
        [Association(@"QueryParmsReferencesStoredProcsAndQueries")]
        public StoredProcsAndQueries StoredProcOrQueryID
        {
            get { return fStoredProcOrQueryID; }
            set { SetPropertyValue<StoredProcsAndQueries>("StoredProcOrQueryID", ref fStoredProcOrQueryID, value); }
        }
        string fParameterName;
        [Size(50)]
        public string ParameterName
        {
            get { return fParameterName; }
            set { SetPropertyValue<string>("ParameterName", ref fParameterName, value); }
        }
        string fDataType;
        [Size(20)]
        public string DataType
        {
            get { return fDataType; }
            set { SetPropertyValue<string>("DataType", ref fDataType, value); }
        }
        string fDefaultValue;
        [Size(254)]
        public string DefaultValue
        {
            get { return fDefaultValue; }
            set { SetPropertyValue<string>("DefaultValue", ref fDefaultValue, value); }
        }
        string fUseDefault;
        [Size(1)]
        public string UseDefault
        {
            get { return fUseDefault; }
            set { SetPropertyValue<string>("UseDefault", ref fUseDefault, value); }
        }
        string fPromptForDefault;
        [Size(1)]
        public string PromptForDefault
        {
            get { return fPromptForDefault; }
            set { SetPropertyValue<string>("PromptForDefault", ref fPromptForDefault, value); }
        }
        string fPromptText;
        [Size(80)]
        public string PromptText
        {
            get { return fPromptText; }
            set { SetPropertyValue<string>("PromptText", ref fPromptText, value); }
        }
        int fExecutionOrder;
        public int ExecutionOrder
        {
            get { return fExecutionOrder; }
            set { SetPropertyValue<int>("ExecutionOrder", ref fExecutionOrder, value); }
        }
        int fDisplayOrder;
        public int DisplayOrder
        {
            get { return fDisplayOrder; }
            set { SetPropertyValue<int>("DisplayOrder", ref fDisplayOrder, value); }
        }
        string fCondition;
        [Size(30)]
        public string Condition
        {
            get { return fCondition; }
            set { SetPropertyValue<string>("Condition", ref fCondition, value); }
        }
        string fLookupTable;
        [Size(50)]
        public string LookupTable
        {
            get { return fLookupTable; }
            set { SetPropertyValue<string>("LookupTable", ref fLookupTable, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"QueryParmsReferencesMPetUsers")]
        public MPetUsers CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<MPetUsers>("CreatedBy", ref fCreatedBy, value); }
        }
        MPetUsers fModifedBy;
        [Association(@"QueryParmsReferencesMPetUsers1")]
        public MPetUsers ModifedBy
        {
            get { return fModifedBy; }
            set { SetPropertyValue<MPetUsers>("ModifedBy", ref fModifedBy, value); }
        }
        DateTime fLastModified;
        public DateTime LastModified
        {
            get { return fLastModified; }
            set { SetPropertyValue<DateTime>("LastModified", ref fLastModified, value); }
        }
    }

}
