using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult PictureUpload()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {

            /*var name = (string)RouteData.Values["id"];
            var model = PetManagemet.GetByBame(name);
            if (model == null)
                return RedirectToAction("NotFound");
            return (model);*/
            var name = (string)RouteData.Values["id"];
            object model = null;
            if (model == null)
                return RedirectToAction("NotFound");
            return View(model);
        }
        public ActionResult NotFound()
        {
            ViewData["ErrorCode"] = "NFE";
            ViewData["Description"] = "La mascota no se encuentra" + "en la base de datos";
            return View();
        }
        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = @"C:\Users\Zigma\Pictures\Varios\" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name = ".jpg";
            return File(picture, contentType, fileName);
        }

        public HttpStatusCodeResult UnauthorizedError()
        {
            return new HttpUnauthorizedResult("Error de acceso no autorizado");
        }

        public ActionResult NotFoundError()
        {
            return HttpNotFound("Nada por aqui...");
        }
    }
}
