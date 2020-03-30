using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TextWebService
{
  
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class TextWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string ToUpper(string inputString)
        {
            return inputString.ToUpper();
        }
        [WebMethod]
        public string ToLower(string inputString)
        {
            return inputString.ToLower();
        }
    }
}
