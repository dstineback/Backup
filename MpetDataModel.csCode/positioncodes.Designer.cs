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

    public partial class positioncodes : XPLiteObject
    {
        int fn_positioncodeid;
        [Key(true)]
        public int n_positioncodeid
        {
            get { return fn_positioncodeid; }
            set { SetPropertyValue<int>("n_positioncodeid", ref fn_positioncodeid, value); }
        }
        string fpositioncodeid;
        [Size(20)]
        public string positioncodeid
        {
            get { return fpositioncodeid; }
            set { SetPropertyValue<string>("positioncodeid", ref fpositioncodeid, value); }
        }
        string fdescription;
        [Size(254)]
        public string description
        {
            get { return fdescription; }
            set { SetPropertyValue<string>("description", ref fdescription, value); }
        }
        MPetUsers fModifiedBy;
        [Association(@"positioncodesReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime flast_modified;
        public DateTime last_modified
        {
            get { return flast_modified; }
            set { SetPropertyValue<DateTime>("last_modified", ref flast_modified, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"positioncodesReferencesMPetUsers")]
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
        [Association(@"time_batch_timesReferencespositioncodes", typeof(time_batch_times))]
        public XPCollection<time_batch_times> time_batch_timess { get { return GetCollection<time_batch_times>("time_batch_timess"); } }
    }

}