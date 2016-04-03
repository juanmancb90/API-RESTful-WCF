using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceRestFulTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImp" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestServiceImp.svc or RestServiceImp.svc.cs at the Solution Explorer and start debugging.
    public class RestServiceImp : IRestServiceImp
    {
        public void DoWork()
        {
        }

        public string dataXML(string id) 
        {
            return "Request id: " + id;
        }

        public string dataJSON(string id) 
        {
            return "request id: " + id;
        }
    }
}
