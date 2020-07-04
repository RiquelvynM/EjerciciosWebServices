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
    public class Ejercicio17Controller : ControllerBase
    {
        public List<string> Get(string a, string b, string c, string d, string e)
        {
            CEjercicio17 Procesar = new CEjercicio17();

            return Procesar.Calcular(a, b, c, d, e);
        }
    }
}
