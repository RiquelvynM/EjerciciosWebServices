using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*7) Crear un programa que use el operador condicional para mostrar un el valor absoluto de un número
         de la siguiente forma: si el número es positivo, se mostrará tal cual; si es negativo, se mostrará
         cambiado de signo. */
    public class CEjercicio7
    {
        public int Resultado { get; set; }

        public int Calcular(int a)
        {
            int result = a < 0 ? a *= -1 : a;

            return result;


        }
    }
}
