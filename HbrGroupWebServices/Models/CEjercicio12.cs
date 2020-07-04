using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*12) Crear un programa que muestre los números del 15 al 5, descendiendo (pista: en cada pasada habrá
          que descontar 1, por ejemplo haciendo i=i-1, que se puede abreviar i--). */
    public class CEjercicio12
    {
        public List<int> Calcular()
        {
            List<int> resultados = new List<int>();
            //creamos bucle iniciado en 15, y restamos uno en cada vuelta
            for (int i = 15; i >= 5; i--)
            {

                resultados.Add(i);
            }

            return resultados;
        }
    }
}
