using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class Estudiantes
    {[Key]
     public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int IDDepartamento { get; set; }

        public virtual Departamentos Departamento { get; set; }

    }

}