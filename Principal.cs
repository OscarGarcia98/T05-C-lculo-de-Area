using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    class Principal
    {
        Figura fig = new Figura();
        Operaciones op = new Operaciones();     //Instancio los objetos para poder trabajar con sus atributos y métodos

        public void Mostrar()       //Método que funciona como un menú para obtener el área de la figura elegida
        {
            double res = 0; int n;      //res guardará el resultado de la operación. n servirá para el switch
            Console.WriteLine("Cálculo de áreas");
            Console.WriteLine("Seleccion la figura a resolver");
            Console.WriteLine("1.-Triángulo\n2.-Cuadrado\n3.-Rectángulo\n4.-Salir\n");
            n = Convert.ToInt32(Console.ReadLine());        //El número introducido debe ser uno perteneciente al switch para elegir una figura o para terminar el programa
            if (n != 4)     //En caso de que el número no sea uno valido se mostrará un mensaje al usuario
            {
               
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ingrese el valor de la Base: ");
                        fig.LadoA = Convert.ToDouble(Console.ReadLine());       //Se piden los datos al usuario para su respectiva figura
                        Console.WriteLine("Ingrese el valor de la Altura: ");
                        fig.LadoB = Convert.ToDouble(Console.ReadLine());

                        res = op.CalcularArea(fig.LadoA, fig.LadoB);        //Se realiza la operación 
                        fig.Nombre = "Triángulo";                               //Así como se obtiene el nombre de la figura para mostrarla al usuario
                       
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el valor de un Lado: ");
                        fig.LadoA = Convert.ToDouble(Console.ReadLine());   //Se piden los datos al usuario para su respectiva figura
                        res = op.CalcularArea(fig.LadoA);   //Se realiza la operación 
                        fig.Nombre = "Cuadrado";    //Así como se obtiene el nombre de la figura para mostrarla al usuario

                        break;

                    case 3:
                        Console.WriteLine("Ingrese el valor de la Base: ");
                        fig.LadoA = Convert.ToDouble(Console.ReadLine());           //Se piden los datos al usuario para su respectiva figura
                        Console.WriteLine("Ingrese el valor de la Altura: ");
                        fig.LadoB = Convert.ToDouble(Console.ReadLine());

                        res = op.CalcularArea(fig.LadoA, fig.LadoB, 1); //Se realiza la operación 
                        fig.Nombre = "Rectángulo";      //Así como se obtiene el nombre de la figura para mostrarla al usuario

                        break;

                    default:
                        Console.WriteLine("Debe ingresar un valor valido");//En caso de ingresar un número invalido se le notificará al usuario y el menú se volverá a desplegar
                        Mostrar();
                        break;

                }
                Console.WriteLine("El área del {0} es igual a {1}\n", fig.Nombre, res.ToString());      //Se muestra el resultado de la figura elegida

                Mostrar();      //Se reinicia el programa 
            }

            




        }



    }
}
