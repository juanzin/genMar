using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace calculadora
{
    /// <summary>
    /// Summary description for calculadora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class calculadora : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double suma(double numero1, double numero2) {

            return numero1 + numero2;
        }

        [WebMethod]
        public double resta(double numero1, double numero2) {
            return numero1 - numero2;
        }

        [WebMethod]
        public double multiplicacion(double numero1, double numero2) {
            return numero1 * numero2;
        }

        [WebMethod]
        public double division(double numero1, double numero2) {

            return numero1 / numero2;
        }
    }
}
