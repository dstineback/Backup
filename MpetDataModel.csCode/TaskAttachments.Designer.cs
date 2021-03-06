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

    public partial class TaskAttachments : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>("ID", ref fID, value); }
        }
        Tasks fn_TaskID;
        [Association(@"TaskAttachmentsReferencesTasks")]
        public Tasks n_TaskID
        {
            get { return fn_TaskID; }
            set { SetPropertyValue<Tasks>("n_TaskID", ref fn_TaskID, value); }
        }
        string fDocType;
        [Size(10)]
        public string DocType
        {
            get { return fDocType; }
            set { SetPropertyValue<string>("DocType", ref fDocType, value); }
        }
        string fDescription;
        [Size(254)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        string fShortName;
        [Size(20)]
        public string ShortName
        {
            get { return fShortName; }
            set { SetPropertyValue<string>("ShortName", ref fShortName, value); }
        }
        string fLocationOrURL;
        [Size(2304)]
        public string LocationOrURL
        {
            get { return fLocationOrURL; }
            set { SetPropertyValue<string>("LocationOrURL", ref fLocationOrURL, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"TaskAttachmentsReferencesMPetUsers")]
        public MPetUsers CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<MPetUsers>("CreatedBy", ref fCreatedBy, value); }
        }
        DateTime fCreatedDate;
        public DateTime CreatedDate
        {
            get { return fCreatedDate; }
            set { SetPropertyValue<DateTime>("CreatedDate", ref fCreatedDate, value); }
        }
        MPetUsers fModifiedBy;
        [Association(@"TaskAttachmentsReferencesMPetUsers1")]
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
