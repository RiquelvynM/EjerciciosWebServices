using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    public class CEjercicio5
    {
        /*5) Crear un programa que pida una letra al usuario y diga si se trata de una vocal. */
        public string Resultado { get; set; }

        public string Calcular(string letra)
        {
            string result;

            switch (letra)
            {
                case "a":
                    result ="Es una vocal";
                    break;
                case "e":
                    result = "Es una vocal";
                    break;
                case "i":
                    result = "Es una vocal";
                    break;
                case "o":
                    result = "Es una vocal";
                    break;
                case "u":
                    result = "Es una vocal";
                    break;
                default:
                    result = "No es una vocal";
                    break;

            }

            return result;
        }
    }
}
