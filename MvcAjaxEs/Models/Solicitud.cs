using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAjaxEs.Models
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public string Nombre { get; set; }


        public List<Dependencia>    Dependencias { get; set; }
    }
    public class Dependencia
    {
        public int IdSolicitud { get; set; }
        public int IdDependencia { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

    }

    public class RepositorySolicitud
    {
        public static Solicitud solicitud = new Solicitud() { 
            IdSolicitud=1,Nombre="Solicitud Uno",
            Dependencias = new List<Dependencia>()
            {
                new Dependencia(){IdDependencia=1,IdSolicitud=1,Nombre="Dep 1",FechaDesde=DateTime.Now,FechaHasta=DateTime.Now},
                new Dependencia(){IdDependencia=2,IdSolicitud=1,Nombre="Dep 2",FechaDesde=DateTime.Now,FechaHasta=DateTime.Now},
                new Dependencia(){IdDependencia=3,IdSolicitud=1,Nombre="Dep 3",FechaDesde=DateTime.Now,FechaHasta=DateTime.Now},
            }
        
        };


        public static Solicitud GetSolicitud(){
            return solicitud;
        }


    }
}