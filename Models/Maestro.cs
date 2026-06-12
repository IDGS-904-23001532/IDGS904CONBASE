using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904CONBASE.Models
{
    public class Maestro
    {

    public int  id { get; set; }
        [Required]
        [StringLength(100)]
        public string nombre { get; set; }
        [StringLength(100)]
        public string apaterno { get; set; }
        [StringLength(100)]
        public string materno { get; set; }
        [StringLength(100)]
        public string carrera { get; set; }

    public int numero { get; set; }

    

    }
}