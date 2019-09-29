using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    class Operaciones
    {
        
        //Métodos sobrecargados que realizan una operación similiar pero con diferentes parámetros
        public double CalcularArea(double lado1, double lado2)      //Regresa el resultado del área de un Triángulo
        {

            return (lado1 * lado2) / 2;
        }

        public double CalcularArea(double lado1)        //Regresa el resultado del área de un cuadrado
        {
            return (lado1 * lado1);
        }
        public double CalcularArea(double lado1, double lado2, int valor)   //Regresa el resultado del área de un rectángulo
        {
            return (lado1 * lado2);
        }

    }
}
