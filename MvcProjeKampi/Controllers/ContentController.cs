using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GettAllContent(string p)
        {
            var values = cm.GetList(p);
            //var values = context.Contents.ToList();
            return View(values);
        }
        public ActionResult ContentByHeading(int id)
        {
            var values = cm.GetListByHeadingID(id);
            return View(values);
        }
    }
}