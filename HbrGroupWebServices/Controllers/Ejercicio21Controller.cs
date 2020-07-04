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
    public class Ejercicio21Controller : ControllerBase
    {
        public int[][] Get(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10,
            int num11, int num12, int num13, int num14, int num15)
        {
            CEjercicio21 Procesar = new CEjercicio21();

            

            return Procesar.Procesar(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15);

            
        }
    }
}
