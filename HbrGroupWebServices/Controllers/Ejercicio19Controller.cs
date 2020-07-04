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
    public class Ejercicio19Controller : ControllerBase
    {
        public List<int> Get(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
            CEjercicio19 Procesar = new CEjercicio19();

            return Procesar.Calcular(a, b,c,d,e,f,g,h,i,j);
        }
    }
}
