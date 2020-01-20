using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeneroGenerator.Entidades
{
    public class Generos
    {
        [Key]
        public int GeneroId { get; set; }
        public string Nombre { get; set; }

        public Generos()
        {
            GeneroId = 0;
            Nombre = string.Empty;

        }

    }
}
