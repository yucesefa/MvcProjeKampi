using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_FluentValidation;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
        public ActionResult GetContactDetails(int id)
        {
            var values = cm.GetById(id);
            return View(values);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}