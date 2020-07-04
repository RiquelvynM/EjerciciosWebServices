using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    public class CEjercicio3
    {
        /*3) Crear un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un
             primer número entero. Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por
             cualquier número es 0". Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo
             número y se mostrará el producto de ambos. */
        public string Resultado { get; set; }
        public string Calcular(int a, int b)
        {
            string result;
            
            if (a == 0)
            {
                 result = "El producto de 0 por cualquier numero es 0";

            }
            else
            {
                int mult = a * b;

                result = mult.ToString();
            }

            return result;
        }
    }
}
