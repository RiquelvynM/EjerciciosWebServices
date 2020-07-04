using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*11) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo),
          usando "do..while". */
    public class CEjercicio11
    {
        public List<int> Calcular()
        {
            int num = 26;
            int par;

            List<int> resultados = new List<int>();
            //mientras que en el ciclo restamos dos al numero inical y asi obtnemos nuestro numero par, que luego dividimos entre dos.
            do
            {

                par = num - 2;
                resultados.Add(par);
                num -= 2;

            } while (num > 10);

            return resultados;
        }        
    }
}
