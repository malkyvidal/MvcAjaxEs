using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAjaxEs.Models;
namespace MvcAjaxEs.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        public ActionResult Index()
        {
            return View(RepositorySolicitud.solicitud);
        }


        [ChildActionOnly]
        public ActionResult Dependendencias()
        {
            return PartialView(RepositorySolicitud.solicitud.Dependencias);
        }

        public ActionResult Edit(int idDependencia,int idSolicitud)
        {
            var depe = RepositorySolicitud.GetSolicitud().Dependencias.Where(d => d.IdDependencia == 1 && d.IdSolicitud == idSolicitud).FirstOrDefault();
            return PartialView(depe);
        }
    }
}