using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    public class CEjercicio6
    {
        /*6) Crear un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo",
             "Los dos números son positivos" o bien "Ninguno de los números es positivo", según corresponda. */
        public string Resultado { get; set; }

        public string Calcular(int a, int b)
        {
            string result="";

            if (a > 0)
            {
                if (b > 0)
                {
                    result = "Los dos numeros son positivos";
                }
                else
                {
                    result = "Uno de los numeros es positivo";
                }
            }
            if (a < 0)
            {
                if (b < 0)
                {
                    result ="Ninguno de los numeros es positivo";
                }
                else
                {
                    result ="Uno de los numeros es positivo";
                }
            }

            return result;
        }
    }
}
