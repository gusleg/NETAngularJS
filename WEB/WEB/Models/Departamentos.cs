using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class Departamentos
    {[Key]
     public int IDDepartamento { get; set; }
     public string Nombre { get; set; }
     public string Codigo { get; set; }
     public virtual ICollection<Estudiantes> Estudiantes { get; set; }


    }
}