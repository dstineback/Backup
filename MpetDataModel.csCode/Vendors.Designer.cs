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

    public partial class Vendors : XPLiteObject
    {
        int fn_vendorid;
        [Key(true)]
        public int n_vendorid
        {
            get { return fn_vendorid; }
            set { SetPropertyValue<int>("n_vendorid", ref fn_vendorid, value); }
        }
        string fvendorid;
        [Size(10)]
        public string vendorid
        {
            get { return fvendorid; }
            set { SetPropertyValue<string>("vendorid", ref fvendorid, value); }
        }
        string fdescription;
        [Size(254)]
        public string description
        {
            get { return fdescription; }
            set { SetPropertyValue<string>("description", ref fdescription, value); }
        }
        Carriers fn_CarrierID;
        [Association(@"VendorsReferencesCarriers")]
        public Carriers n_CarrierID
        {
            get { return fn_CarrierID; }
            set { SetPropertyValue<Carriers>("n_CarrierID", ref fn_CarrierID, value); }
        }
        string faddress1;
        [Size(40)]
        public string address1
        {
            get { return faddress1; }
            set { SetPropertyValue<string>("address1", ref faddress1, value); }
        }
        string faddress2;
        [Size(30)]
        public string address2
        {
            get { return faddress2; }
            set { SetPropertyValue<string>("address2", ref faddress2, value); }
        }
        string fcity;
        [Size(15)]
        public string city
        {
            get { return fcity; }
            set { SetPropertyValue<string>("city", ref fcity, value); }
        }
        string fcontact;
        [Size(20)]
        public string contact
        {
            get { return fcontact; }
            set { SetPropertyValue<string>("contact", ref fcontact, value); }
        }
        string fcountry;
        [Size(10)]
        public string country
        {
            get { return fcountry; }
            set { SetPropertyValue<string>("country", ref fcountry, value); }
        }
        string fextention;
        [Size(10)]
        public string extention
        {
            get { return fextention; }
            set { SetPropertyValue<string>("extention", ref fextention, value); }
        }
        string ffax;
        [Size(20)]
        public string fax
        {
            get { return ffax; }
            set { SetPropertyValue<string>("fax", ref ffax, value); }
        }
        string fFOB;
        [Size(25)]
        public string FOB
        {
            get { return fFOB; }
            set { SetPropertyValue<string>("FOB", ref fFOB, value); }
        }
        string fFreightTerms;
        [Size(25)]
        public string FreightTerms
        {
            get { return fFreightTerms; }
            set { SetPropertyValue<string>("FreightTerms", ref fFreightTerms, value); }
        }
        string fnotes;
        [Size(254)]
        public string notes
        {
            get { return fnotes; }
            set { SetPropertyValue<string>("notes", ref fnotes, value); }
        }
        string fPaymentTerms;
        [Size(25)]
        public string PaymentTerms
        {
            get { return fPaymentTerms; }
            set { SetPropertyValue<string>("PaymentTerms", ref fPaymentTerms, value); }
        }
        string fphone;
        [Size(20)]
        public string phone
        {
            get { return fphone; }
            set { SetPropertyValue<string>("phone", ref fphone, value); }
        }
        string fstate;
        [Size(2)]
        public string state
        {
            get { return fstate; }
            set { SetPropertyValue<string>("state", ref fstate, value); }
        }
        decimal ftax_pct;
        public decimal tax_pct
        {
            get { return ftax_pct; }
            set { SetPropertyValue<decimal>("tax_pct", ref ftax_pct, value); }
        }
        string fzip;
        [Size(10)]
        public string zip
        {
            get { return fzip; }
            set { SetPropertyValue<string>("zip", ref fzip, value); }
        }
        string fVendorWebsiteURL;
        [Size(254)]
        public string VendorWebsiteURL
        {
            get { return fVendorWebsiteURL; }
            set { SetPropertyValue<string>("VendorWebsiteURL", ref fVendorWebsiteURL, value); }
        }
        MPetUsers fCreatedBy;
        [Association(@"VendorsReferencesMPetUsers")]
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
        [Association(@"VendorsReferencesMPetUsers1")]
        public MPetUsers ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<MPetUsers>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fLast_Modified;
        public DateTime Last_Modified
        {
            get { return fLast_Modified; }
            set { SetPropertyValue<DateTime>("Last_Modified", ref fLast_Modified, value); }
        }
        string fb_IsActive;
        [Size(1)]
        public string b_IsActive
        {
            get { return fb_IsActive; }
            set { SetPropertyValue<string>("b_IsActive", ref fb_IsActive, value); }
        }
        PaymentTerms fn_PaymentTermsID;
        [Association(@"VendorsReferencesPaymentTerms")]
        public PaymentTerms n_PaymentTermsID
        {
            get { return fn_PaymentTermsID; }
            set { SetPropertyValue<PaymentTerms>("n_PaymentTermsID", ref fn_PaymentTermsID, value); }
        }
        FreightTerms fn_FreightTermID;
        [Association(@"VendorsReferencesFreightTerms")]
        public FreightTerms n_FreightTermID
        {
            get { return fn_FreightTermID; }
            set { SetPropertyValue<FreightTerms>("n_FreightTermID", ref fn_FreightTermID, value); }
        }
        FreightOnBoard fn_FreightOnBoardID;
        [Association(@"VendorsReferencesFreightOnBoard")]
        public FreightOnBoard n_FreightOnBoardID
        {
            get { return fn_FreightOnBoardID; }
            set { SetPropertyValue<FreightOnBoard>("n_FreightOnBoardID", ref fn_FreightOnBoardID, value); }
        }
        string fEmailAddress;
        [Size(254)]
        public string EmailAddress
        {
            get { return fEmailAddress; }
            set { SetPropertyValue<string>("EmailAddress", ref fEmailAddress, value); }
        }
        [Association(@"GriefLogsReferencesVendors", typeof(GriefLogs))]
        public XPCollection<GriefLogs> GriefLogsCollection { get { return GetCollection<GriefLogs>("GriefLogsCollection"); } }
        [Association(@"MaintenanceObjectsReferencesVendors", typeof(MaintenanceObjects))]
        public XPCollection<MaintenanceObjects> MaintenanceObjectsCollection { get { return GetCollection<MaintenanceObjects>("MaintenanceObjectsCollection"); } }
        [Association(@"MasterpartsReferencesVendors", typeof(Masterparts))]
        public XPCollection<Masterparts> MasterpartsCollection { get { return GetCollection<Masterparts>("MasterpartsCollection"); } }
        [Association(@"partxactionsReferencesVendors", typeof(partxactions))]
        public XPCollection<partxactions> partxactionsCollection { get { return GetCollection<partxactions>("partxactionsCollection"); } }
        [Association(@"purchaseordersReferencesVendors", typeof(purchaseorders))]
        public XPCollection<purchaseorders> purchaseordersCollection { get { return GetCollection<purchaseorders>("purchaseordersCollection"); } }
        [Association(@"requisitionitemsReferencesVendors", typeof(requisitionitems))]
        public XPCollection<requisitionitems> requisitionitemsCollection { get { return GetCollection<requisitionitems>("requisitionitemsCollection"); } }
        [Association(@"VendorPartsReferencesVendors", typeof(VendorParts))]
        public XPCollection<VendorParts> VendorPartsCollection { get { return GetCollection<VendorParts>("VendorPartsCollection"); } }
    }

}
