namespace Syncfusion.Report.Server.API.Helper.V4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class ApiReportParameters
    {

        [DataMember]
        public List<ApiReportParameter> ReportParameter
        {
            get;
            set;
        }
    }
}
