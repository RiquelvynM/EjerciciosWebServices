using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*13) Crear un programa que muestre los primeros ocho números pares (pista: en cada pasada habrá que
          aumentar de 2 en 2, o bien mostrar el doble del valor que hace de contador). */
    public class CEjercicio13
    {
        public List<int> Calcular()
        {
            List<int> resultados = new List<int>();

            for (int i = 2; i < 18; i += 2)
            {
                resultados.Add(i);
            }

            return resultados;
        }
    }
}
