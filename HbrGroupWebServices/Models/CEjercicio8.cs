using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    public class CEjercicio8
    {
        /*8) Crea un programa que escriba en pantalla los números del 1 al 10, usando "while". */
        public List<int> Resultado { get; set; }
        public List<int> Calcular()
        {
            int Num = 0;

            List<int> Resultados = new List<int>();

            while (Num <= 10)
            {
                Num++;
                Resultados.Add(Num);
            }


            return Resultados;
        }
    }
}
