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

    public partial class Jobcrews : XPLiteObject
    {
        int fn_jobcrewid;
        [Key(true)]
        public int n_jobcrewid
        {
            get { return fn_jobcrewid; }
            set { SetPropertyValue<int>("n_jobcrewid", ref fn_jobcrewid, value); }
        }
        Jobsteps fJobstepID;
        [Association(@"JobcrewsReferencesJobsteps")]
        public Jobsteps JobstepID
        {
            get { return fJobstepID; }
            set { SetPropertyValue<Jobsteps>("JobstepID", ref fJobstepID, value); }
        }
        Jobs fJobID;
        [Association(@"JobcrewsReferencesJobs")]
        public Jobs JobID
        {
            get { return fJobID; }
            set { SetPropertyValue<Jobs>("JobID", ref fJobID, value); }
        }
        laborclasses fn_laborclassid;
        [Association(@"JobcrewsReferenceslaborclasses")]
        public laborclasses n_laborclassid
        {
            get { return fn_laborclassid; }
            set { SetPropertyValue<laborclasses>("n_laborclassid", ref fn_laborclassid, value); }
        }
        MPetUsers fn_personid;
        [Association(@"JobcrewsReferencesMPetUsers")]
        public MPetUsers n_personid
        {
            get { return fn_personid; }
            set { SetPropertyValue<MPetUsers>("n_personid", ref fn_personid, value); }
        }
        skills fn_skillid;
        [Association(@"JobcrewsReferencesskills")]
        public skills n_skillid
        {
            get { return fn_skillid; }
            set { SetPropertyValue<skills>("n_skillid", ref fn_skillid, value); }
        }
        decimal factuallen;
        public decimal actuallen
        {
            get { return factuallen; }
            set { SetPropertyValue<decimal>("actuallen", ref factuallen, value); }
        }
        decimal festlen;
        public decimal estlen
        {
            get { return festlen; }
            set { SetPropertyValue<decimal>("estlen", ref festlen, value); }
        }
        decimal fPayfactor;
        public decimal Payfactor
        {
            get { return fPayfactor; }
            set { SetPropertyValue<decimal>("Payfactor", ref fPayfactor, value); }
        }
        string fPayfactorText;
        [Size(254)]
        public string PayfactorText
        {
            get { return fPayfactorText; }
            set { SetPropertyValue<string>("PayfactorText", ref fPayfactorText, value); }
        }
        Shifts fn_ShiftID;
        [Association(@"JobcrewsReferencesShifts")]
        public Shifts n_ShiftID
        {
            get { return fn_ShiftID; }
            set { SetPropertyValue<Shifts>("n_ShiftID", ref fn_ShiftID, value); }
        }
        Paycodes fn_PayCodeID;
        [Association(@"JobcrewsReferencesPaycodes")]
        public Paycodes n_PayCodeID
        {
            get { return fn_PayCodeID; }
            set { SetPropertyValue<Paycodes>("n_PayCodeID", ref fn_PayCodeID, value); }
        }
        DateTime fWorkDate;
        public DateTime WorkDate
        {
            get { return fWorkDate; }
            set { SetPropertyValue<DateTime>("WorkDate", ref fWorkDate, value); }
        }
        int fDMRKey;
        public int DMRKey
        {
            get { return fDMRKey; }
            set { SetPropertyValue<int>("DMRKey", ref fDMRKey, value); }
        }
        DateTime fCertificationDate;
        public DateTime CertificationDate
        {
            get { return fCertificationDate; }
            set { SetPropertyValue<DateTime>("CertificationDate", ref fCertificationDate, value); }
        }
        DateTime fCertificationDateExpires;
        public DateTime CertificationDateExpires
        {
            get { return fCertificationDateExpires; }
            set { SetPropertyValue<DateTime>("CertificationDateExpires", ref fCertificationDateExpires, value); }
        }
        int fRateType;
        public int RateType
        {
            get { return fRateType; }
            set { SetPropertyValue<int>("RateType", ref fRateType, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"JobcrewsReferencesMPetUsers1")]
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
        [Association(@"JobcrewsReferencesMPetUsers2")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fLast_modified;
        public DateTime Last_modified
        {
            get { return fLast_modified; }
            set { SetPropertyValue<DateTime>("Last_modified", ref fLast_modified, value); }
        }
        [Association(@"time_batch_timesReferencesJobcrews", typeof(time_batch_times))]
        public XPCollection<time_batch_times> time_batch_timess { get { return GetCollection<time_batch_times>("time_batch_timess"); } }
    }

}