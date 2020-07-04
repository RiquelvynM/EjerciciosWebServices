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
    public class Ejercicio15Controller : ControllerBase
    {
        public List<string> Get()
        {
            CEjercicio15 Procesar = new CEjercicio15();


            return Procesar.Calcular();
        }
    }
}
