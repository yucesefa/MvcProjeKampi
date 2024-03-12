using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager image = new ImageFileManager(new EfImageFilDal());
        public ActionResult Index()
        {
            var values = image.GetList();
            return View(values);
        }
    }
}