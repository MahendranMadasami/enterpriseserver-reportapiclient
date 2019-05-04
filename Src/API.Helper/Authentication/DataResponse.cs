using System.Collections.Generic;
using System.Net;

namespace Syncfusion.Report.Server.API.Helper.Authentication
{
    public class DataResponse<T>
    {
        public dynamic Content { get; set; }
        public List<object> Data { get; set; }

        public HttpStatusCode StatusCode;
    }
}
