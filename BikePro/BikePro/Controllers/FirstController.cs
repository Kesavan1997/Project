using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikePro.Models;

namespace BikePro.Controllers
{
    public class FirstController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Coimbatore()
        {
            return View();
        }
        public ActionResult Chennai()
        {
            return View();
        }
        public ActionResult Trichy()
        {
            return View();
        }
        public ActionResult Madurai()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Dbtable db)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DatabasebikeEntities df = new DatabasebikeEntities();
                    df.Dbtables.Add(db);
                    df.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "User not found";
                    return View();
                }
            }
          catch (Exception ex)
            {
                ModelState.Clear();
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Dbtable db)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DatabasebikeEntities df = new DatabasebikeEntities();
                    df.Dbtables.Add(db);
                    df.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "User not found";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ModelState.Clear();
                return View();
            }
        }
    }
}