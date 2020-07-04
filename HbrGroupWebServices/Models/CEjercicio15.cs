using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    public class CEjercicio15
    {
        /*15) Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector. */
        public List<string> Calcular()
        {
            List<string> resultado = new List<string>();

            Random rdm = new Random();
            int numMenor;
            string Repite = "";

            int[] vector = new int[5];

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rdm.Next(0, 50);
            }

            numMenor = vector[0];

            for (int v = 0; v < vector.Length; v++)
            {
                if (vector[v]>numMenor)
                {
                    numMenor = vector[v];
                }
            }

            for (int r = 0; r < vector.Length; r++)
            {
                if (vector[0]== vector[r])
                {
                    Repite = "Se repite";
                }
                else
                {
                    Repite = "No se repite";
                }
            }
            resultado.Add(numMenor.ToString());
            resultado.Add(Repite);

            return resultado;

        }
    }
}
