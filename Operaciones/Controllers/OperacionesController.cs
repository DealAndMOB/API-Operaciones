using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Operaciones.Controllers
{
    public class OperacionesController : ApiController
    {
        [ActionName("CalculoArea")]
        [HttpGet]
        public double Circulo(double radio)
        {
            double pi = 3.1416;
            double resultado = pi * (radio * radio);
            return resultado;
        }


        [ActionName("AreaTriangulo")]
        [HttpGet]
        public double Triangulo(double basecerru, double altura)
        {
            double resultado = (basecerru * altura) / 2;
            return resultado;
        }
        [ActionName("CalculoHipotenusa")]
        [HttpGet]
        public double Pitagoras(double catetoAdy, double catetoOpues)
        {
            double hipotenusa = (catetoAdy * catetoAdy) + (catetoOpues * catetoOpues);
            return Math.Sqrt(hipotenusa);
        }
    }
}
