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
    public class Ejercicio3Controller : ControllerBase
    {
        public CEjercicio3 Get(int a, int b)
        {
            CEjercicio3 Procesar = new CEjercicio3();

            Procesar = new CEjercicio3() { Resultado = Procesar.Calcular(a, b) };

            return Procesar;
        }
        


    }
}
