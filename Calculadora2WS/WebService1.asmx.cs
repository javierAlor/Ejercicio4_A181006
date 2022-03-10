using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculadora2WS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public decimal cuadrado(decimal lado1, decimal lado2) {
            Calcular c = new Calcular();
            return c.cuadrado(lado1, lado2);
        }
        [WebMethod]
        public decimal triangulo(decimal b, decimal a)
        {
            Calcular c = new Calcular();
            return c.triangulo(a , b);
        }
        [WebMethod]
        public double circulo(double radio)
        {
            Calcular c = new Calcular();
            return c.circulo(radio);
        }



    }
}
