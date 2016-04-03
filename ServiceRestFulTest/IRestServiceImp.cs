using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceRestFulTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestServiceImp" in both code and config file together.
    [ServiceContract]
    public interface IRestServiceImp
    {
        [OperationContract]
        void DoWork();

        //xml RESTful api 
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "xml/{id}")]
        string dataXML(string id);

        //json RESTful api
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/{id}")]
        string dataJSON(string id);
    }

    
}
