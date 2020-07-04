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
    public class Ejercicio18Controller : ControllerBase
    {
        public List<string> Get(string pais1, int cantP1, string pais2, int cantP2, string pais3, int cantP3, string pais4, int cantP4,
            string pais5, int cantP5)
        {
            CEjercicio18 Procesar = new CEjercicio18();

            return Procesar.Calcular(pais1, cantP1, pais2, cantP2, pais3, cantP3, pais4, cantP4, pais5, cantP5);
        }
    }
}
