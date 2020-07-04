using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*20) Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como dato las
          temperaturas medias mensuales de dichos paises.
          Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
          Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
          a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
          185
          Ing. Patricio Medina
          b - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
          c - Calcular la temperatura media trimestral de cada país.
          e - Imprimr los nombres de las provincias y las temperaturas medias trimestrales.
          f - Imprimir el nombre de la provincia con la temperatura media trimestral mayor. */
    public class CEjercicio20
    {
        public string Pais { get; set; }
        public int  TemperaturaMayor { get; set; }
        public int Temperatura2 { get; set; }
        public int Temperatura3 { get; set; }

        public CEjercicio20(string Ppais, int PTemperatura1, int PTemperatura2, int PTemperatura3)
        {
            int MAY;

            MAY = PTemperatura1; 
            if ((Temperatura2 > MAY)) MAY = PTemperatura2;
            if ((PTemperatura3 > MAY)) MAY = PTemperatura3;


            Pais = Ppais;
            TemperaturaMayor = MAY;
            Temperatura2 = PTemperatura2;
            Temperatura3 = PTemperatura3;
        }


    }
}
