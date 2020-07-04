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
    public class Ejercicio5Controller : ControllerBase
    {
        public CEjercicio5 Get(string a)
        {
            CEjercicio5 Procesar = new CEjercicio5();

            Procesar = new CEjercicio5 { Resultado = Procesar.Calcular(a) };

            return Procesar;
        }

    }
}
