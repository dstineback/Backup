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

    [NonPersistent]
    public partial class filter_GetFilteredPMTasksListResult
    {
        public int n_taskid { get; set; }
        public string taskid { get; set; }
        public string description { get; set; }
        public decimal estdowntime { get; set; }
        public decimal estlength { get; set; }
        public int StandardJob { get; set; }
        public int nAssignedArea { get; set; }
        public string AssignedAreaID { get; set; }
        public string IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }

}
