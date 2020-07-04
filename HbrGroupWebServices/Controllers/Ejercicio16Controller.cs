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
    public class Ejercicio16Controller : ControllerBase
    {
        public List<int> Get(int a, int b, int c, int d, int e) 
        {
            CEjercicio16 Procesar = new CEjercicio16();

            return Procesar.Calcular(a, b, c, d, e);
        }
    }
}
