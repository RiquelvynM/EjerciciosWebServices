using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    public class CEjercicio14
    {
        /*14) Crear un programa que escriba en pantalla los números del 1 al 50 que sean múltiplos de 3 (pista:
              habrá que recorrer todos esos números y ver si el resto de la división entre 3 resulta 0). */
        public List<int> Calcular()
        {
            List<int> numeros = new List<int>();

            int oper;

            //creamos bucle inicado en 3 y que auumenta en uno, mientras el if solo imprime los numeros que se pueden dividir en tres
            for (int i = 3; i <= 50; i++)
            {
                oper = i % 3;

                if (oper == 0)
                {
                    numeros.Add(i);
                }
            }

            return numeros;
        }
    }
}
