namespace Syncfusion.Report.Server.API.Helper.V4.Models
{
    using Syncfusion.Report.Server.API.Helper.V3.Models;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class ApiReportParameter
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<string> Values { get; set; }
    }
}
