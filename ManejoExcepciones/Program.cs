using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExcepciones
{
     class DivNumeros
    {

        int resultado;

        DivNumeros()
        {
            resultado = 0;
        }

        //Crear un método
        public void Division(int num1, int num2)
        {
            try
            {
                resultado = num1 / num2;
            }

            catch (DivideByZeroException e)
            {

                Console.WriteLine("Se ha producido una excepción del tipo: {0}", e);

            }

            finally
            {
                Console.WriteLine("El resultado final es: {0}", resultado);
            }
        }
        static void Main(string[] args)
        {

           DivNumeros divNumeros = new DivNumeros();
            divNumeros.Division(21, 0);

            Console.ReadKey();
        }
    }
}
