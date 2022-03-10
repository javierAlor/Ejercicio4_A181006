using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora2WS
{
    public class Calcular
    {
        public decimal lado1 { get; set; }
        public decimal lado2 { get; set; }

        public decimal a { get; set; }
        public decimal b { get; set; }
        public double r { get; set; }

        public decimal cuadrado(decimal l1, decimal l2)
        {   
            lado1=l1;
            lado2=l2;
            return lado1* lado2;
        }
        public decimal triangulo(decimal b, decimal a)
        {
            return (b * a) / 2;
        }
        public double circulo(double r)
        {
            return 3.1416 *(r*r);
        }


    }
}