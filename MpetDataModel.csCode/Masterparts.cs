using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace MpetDataModel.cs
{

    public partial class Masterparts
    {
        public Masterparts(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
