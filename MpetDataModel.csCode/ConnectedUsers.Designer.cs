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

    public partial class ConnectedUsers : XPLiteObject
    {
        int fn_KeyID;
        [Key(true)]
        public int n_KeyID
        {
            get { return fn_KeyID; }
            set { SetPropertyValue<int>("n_KeyID", ref fn_KeyID, value); }
        }
        MPetUsers fn_UserID;
        [Association(@"ConnectedUsersReferencesMPetUsers")]
        public MPetUsers n_UserID
        {
            get { return fn_UserID; }
            set { SetPropertyValue<MPetUsers>("n_UserID", ref fn_UserID, value); }
        }
        DateTime fLastLogin;
        public DateTime LastLogin
        {
            get { return fLastLogin; }
            set { SetPropertyValue<DateTime>("LastLogin", ref fLastLogin, value); }
        }
        char fConnectionInUse;
        public char ConnectionInUse
        {
            get { return fConnectionInUse; }
            set { SetPropertyValue<char>("ConnectionInUse", ref fConnectionInUse, value); }
        }
        string fWorkStationID;
        public string WorkStationID
        {
            get { return fWorkStationID; }
            set { SetPropertyValue<string>("WorkStationID", ref fWorkStationID, value); }
        }
        string fConnectionString;
        [Size(255)]
        public string ConnectionString
        {
            get { return fConnectionString; }
            set { SetPropertyValue<string>("ConnectionString", ref fConnectionString, value); }
        }
        char fIsWeb;
        public char IsWeb
        {
            get { return fIsWeb; }
            set { SetPropertyValue<char>("IsWeb", ref fIsWeb, value); }
        }
        string fIPAddress;
        [Size(15)]
        public string IPAddress
        {
            get { return fIPAddress; }
            set { SetPropertyValue<string>("IPAddress", ref fIPAddress, value); }
        }
        string fSubnetMask;
        [Size(15)]
        public string SubnetMask
        {
            get { return fSubnetMask; }
            set { SetPropertyValue<string>("SubnetMask", ref fSubnetMask, value); }
        }
        string fGatewayAddress;
        [Size(15)]
        public string GatewayAddress
        {
            get { return fGatewayAddress; }
            set { SetPropertyValue<string>("GatewayAddress", ref fGatewayAddress, value); }
        }
        string fChatEnabled;
        [Size(1)]
        public string ChatEnabled
        {
            get { return fChatEnabled; }
            set { SetPropertyValue<string>("ChatEnabled", ref fChatEnabled, value); }
        }
        int fHttpRemotingChannel;
        public int HttpRemotingChannel
        {
            get { return fHttpRemotingChannel; }
            set { SetPropertyValue<int>("HttpRemotingChannel", ref fHttpRemotingChannel, value); }
        }
        int fPortInUse;
        public int PortInUse
        {
            get { return fPortInUse; }
            set { SetPropertyValue<int>("PortInUse", ref fPortInUse, value); }
        }
    }

}
