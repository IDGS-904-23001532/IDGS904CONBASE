using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904CONBASE.Models
{
    public class Alumno
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100)]

        public string Nombre { get; set; }
        [StringLength(100)]
        public string Apeterno { get; set; }
        [StringLength(150)]
        public string Amaterno { get; set; }
      

            public int Edad { get; set; }

            public string Correo { get; set; }


        }
    }