using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*10) Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while" */
    public class CEjercicio10
    {
        public List<int> Calcular()
        {
            int num = 1;

            List<int> resultados = new List<int>();

            //imprimimos valor de num, y luego aumentamos valor hasta ser menor o igual a 10
            do
            {
                resultados.Add(num);
                num++;

            } while (num <= 10);


            return resultados;
        }

    }
}
