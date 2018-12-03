using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class ProjectoDB:DbContext
    {
        public ProjectoDB():base("ColegioConnection")
        {

        }     

        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
    }
}