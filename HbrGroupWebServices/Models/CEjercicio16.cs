using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*16) Se debe crear un vector donde almacenar 5 sueldos. Ordenar el vector sueldos de menor a mayor. */
    public class CEjercicio16
    {
        public List<int> Calcular(int a, int b, int c, int d, int e)
        {
            List<int> resultados = new List<int>();
            int[] sueldos = new int[5];

            sueldos[0] = a;
            sueldos[1] = b;
            sueldos[2] = c;
            sueldos[3] = d;
            sueldos[4] = e;

            
            for (int p = 0; p < 4; p++)
            {
                for (int f = 0; f < 4 - c; f++)
                {
                    if (sueldos[f] > sueldos[f + 1])
                    {
                        int orden;
                        orden = sueldos[f];
                        sueldos[f] = sueldos[f + 1];
                        sueldos[f + 1] = orden;
                    }
                }
            }

            for (int i = 0; i < sueldos.Length; i++)
            {
                resultados.Add(sueldos[i]);
            }


            return resultados;
        }
    }
}
