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
    public class Ejercicio14Controller : ControllerBase
    {
        public List<int> Get()
        {
            CEjercicio14 Procesar = new CEjercicio14();

            return Procesar.Calcular();
        }
    }
}
