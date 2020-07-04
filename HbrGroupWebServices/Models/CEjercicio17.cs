using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*17) Definir un vector donde almacenar los nombres de 5 países. Confeccionar el algoritmo de
          ordenamiento alfabético.*/
    public class CEjercicio17
    {
        public List<string> Calcular(string a, string b, string c, string d, string e)
        {
            List<string> Resultados = new List<string>();
            string[] paises = new string[5];

            paises[0] = a;
            paises[1] = b;
            paises[2] = c;
            paises[3] = d;
            paises[4] = e;

            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (paises[f].CompareTo(paises[f + 1]) > 0)
                    {
                        String aux;
                        aux = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = aux;

                    }
                }
            }


            for (int i = 0; i < paises.Length; i++)
            {
                Resultados.Add(paises[i]);
            }


            return Resultados;
        }
    }
}
