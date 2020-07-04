using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HbrGroupWebServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HbrGroupWebServices.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Ejercicio1Controller : ControllerBase
    {
        //Metdo que devuelve IEnumerable para recorrer la clase y devuelva sus propiedades
        public IEnumerable<CEjercicio1> Get(int n1, int n2)
        {
            //instanciamos lista que almacene el resultado de las propiedades
            List<CEjercicio1> resultados = new List<CEjercicio1>();

            // aqui instanciamos con el unico proposito de enviarle los parametros
            CEjercicio1 Procesar = new CEjercicio1();


            resultados.Add(new CEjercicio1 { Division = Procesar.CalcularDiv(n1, n2), Modulo = Procesar.CalcularMod(n1, n2) });

            return resultados;

        }

    }
}
