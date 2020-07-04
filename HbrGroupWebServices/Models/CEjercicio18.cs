using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*18) Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de habitantes del
          mismo. Ordenar alfabéticamente e imprimir los resultados. Por último ordenar con respecto a la
          cantidad de habitantes (de mayor a menor) e imprimir nuevamente. */
    public class CEjercicio18
    {
        public List<string> Calcular(string pais1,int cantP1,string pais2,int cantP2, string pais3, int cantP3, string pais4, int cantP4,
            string pais5, int cantP5)
        {
            List<string> resultados = new List<string>();

            string[] paises = new string[5];

            int[] CantHabitantes = new int[5];

            paises[0] = pais1;
            paises[1] = pais2;
            paises[2] = pais3;
            paises[3] = pais4;
            paises[4] = pais5;


            CantHabitantes[0] = cantP1;
            CantHabitantes[1] = cantP2;
            CantHabitantes[2] = cantP3;
            CantHabitantes[3] = cantP4;
            CantHabitantes[4] = cantP5;

            for (int k = 0; k < CantHabitantes.Length; k++)
            {
                for (int f = 0; f < CantHabitantes.Length - 1 - k; f++)
                {
                    if (CantHabitantes[f] < CantHabitantes[f + 1])
                    {
                        int auxhabitantes;
                        auxhabitantes = CantHabitantes[f];
                        CantHabitantes[f] = CantHabitantes[f + 1];
                        CantHabitantes[f + 1] = auxhabitantes;
                        string auxpaises;
                        auxpaises = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = auxpaises;
                    }
                }
            }

            for (int i = 0; i < paises.Length; i++)
            {
                resultados.Add(paises[i]);
                resultados.Add(CantHabitantes[i].ToString());
            }


            return resultados;

        }
    }
}
