using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pharmacy_management.Models;
namespace pharmacy_management.Controllers
{
    public class HomeController : Controller
    {
        GSKDataContext gsk_data = new GSKDataContext();
        GetzDataContext getz_data = new GetzDataContext();
        Sami_pharmaDataContext sami_data = new Sami_pharmaDataContext();
        HiltonDataContext hilton_data = new HiltonDataContext();
        FerozsonsDataContext fer_data = new FerozsonsDataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult gsk()
        {
            ViewBag.Message = "Your gsk page.";

            return View(gsk_data.gsks.ToList());
        }

        public ActionResult getz()
        {
            ViewBag.Message = "Your getz page.";

            return View(getz_data.getzs.ToList());
        }

        public ActionResult sami_pharma()
        {
            ViewBag.Message = "Your sami pharma page.";

            return View(sami_data.samis.ToList());
        }

        public ActionResult hilton()
        {
            ViewBag.Message = "Your hilton page.";

            return View(hilton_data.hiltons.ToList());
        }

        public ActionResult ferozsons()
        {
            ViewBag.Message = "Your ferozsons page.";

            return View(fer_data.ferozsons.ToList());
        }

        public ActionResult Add_Gsk()
        {
            string trademark = Request["trademark"];
            string generic = Request["generic"];
            string cure = Request["cure"];
            string potency = Request["potency"];

            gsk g = new gsk();
            g.trademark = trademark;
            g.generic = generic;
            g.cure = cure;
            g.potency = potency;

            gsk_data.gsks.InsertOnSubmit(g);
            gsk_data.SubmitChanges();

            return RedirectToAction("gsk");
            
        }

        public ActionResult Add_Getz()
        {
            string trademark = Request["trademark"];
            string generic = Request["generic"];
            string cure = Request["cure"];
            string potency = Request["potency"];

            getz g = new getz();
            g.trademark = trademark;
            g.generic = generic;
            g.cure = cure;
            g.potency = potency;

            getz_data.getzs.InsertOnSubmit(g);
            getz_data.SubmitChanges();

            return RedirectToAction("getz");

        }

        public ActionResult Add_Sami()
        {
            string trademark = Request["trademark"];
            string generic = Request["generic"];
            string cure = Request["cure"];
            string potency = Request["potency"];

            sami s = new sami();
            s.trademark = trademark;
            s.generic = generic;
            s.cure = cure;
            s.potency = potency;

            sami_data.samis.InsertOnSubmit(s);
            sami_data.SubmitChanges();

            return RedirectToAction("sami_pharma");

        }

        public ActionResult Add_Hilton()
        {
            string trademark = Request["trademark"];
            string generic = Request["generic"];
            string cure = Request["cure"];
            string potency = Request["potency"];

            hilton g = new hilton();
            g.trademark = trademark;
            g.generic = generic;
            g.cure = cure;
            g.potency = potency;

            hilton_data.hiltons.InsertOnSubmit(g);
            hilton_data.SubmitChanges();

            return RedirectToAction("hilton");

        }

        public ActionResult Add_Ferozsons()
        {
            string trademark = Request["trademark"];
            string generic = Request["generic"];
            string cure = Request["cure"];
            string potency = Request["potency"];

            ferozson g = new ferozson();
            g.trademark = trademark;
            g.generic = generic;
            g.cure = cure;
            g.potency = potency;

            fer_data.ferozsons.InsertOnSubmit(g);
            fer_data.SubmitChanges();

            return RedirectToAction("ferozsons");

        }

        public ActionResult Search_Gsk()
        {
            string sr = Request["search"];
            var search = gsk_data.gsks.First(g => g.trademark == sr);
            return View(search);

        }

        public ActionResult Search_Getz()
        {
            string sr = Request["search"];
            var search = getz_data.getzs.First(g => g.trademark == sr);
            return View(search);

        }

        public ActionResult Search_Sami()
        {
            string sr = Request["search"];
            var search = sami_data.samis.First(g => g.trademark == sr);
            return View(search);

        }

        public ActionResult Search_Hilton()
        {
            string sr = Request["search"];
            var search = hilton_data.hiltons.First(g => g.trademark == sr);
            return View(search);

        }

        public ActionResult Search_Ferozsons()
        {
            string sr = Request["search"];
            var search = fer_data.ferozsons.First(g => g.trademark == sr);
            return View(search);

        }

        public ActionResult Edit_Gsk()
        {
            string sr = Request["edit"];
            var Edit = gsk_data.gsks.First(g => g.trademark == sr);
            return View(Edit);

        }

        public ActionResult Edit_val_Gsk()
        {
            string sr = Request["trademark"];
            var Edit = gsk_data.gsks.First(g => g.trademark == sr);
           
            Edit.generic = Request["generic"];
            Edit.cure = Request["cure"];
            Edit.potency = Request["potency"];
            gsk_data.SubmitChanges();
            return RedirectToAction("gsk");

        }

        public ActionResult Edit_Getz()
        {
            string sr = Request["edit"];
            var Edit = getz_data.getzs.First(g => g.trademark == sr);
            return View(Edit);

        }

        public ActionResult Edit_val_Getz()
        {
            string sr = Request["trademark"];
            var Edit = getz_data.getzs.First(g => g.trademark == sr);

            Edit.generic = Request["generic"];
            Edit.cure = Request["cure"];
            Edit.potency = Request["potency"];
            getz_data.SubmitChanges();
            return RedirectToAction("getz");

        }

        public ActionResult Edit_Sami()
        {
            string sr = Request["edit"];
            var Edit = sami_data.samis.First(g => g.trademark == sr);
            return View(Edit);

        }

        public ActionResult Edit_val_Sami()
        {
            string sr = Request["trademark"];
            var Edit = sami_data.samis.First(g => g.trademark == sr);

            Edit.generic = Request["generic"];
            Edit.cure = Request["cure"];
            Edit.potency = Request["potency"];
            sami_data.SubmitChanges();
            return RedirectToAction("sami_pharma");

        }

        public ActionResult Edit_Hilton()
        {
            string sr = Request["edit"];
            var Edit = hilton_data.hiltons.First(g => g.trademark == sr);
            return View(Edit);

        }

        public ActionResult Edit_val_Hilton()
        {
            string sr = Request["trademark"];
            var Edit = hilton_data.hiltons.First(g => g.trademark == sr);

            Edit.generic = Request["generic"];
            Edit.cure = Request["cure"];
            Edit.potency = Request["potency"];
            hilton_data.SubmitChanges();
            return RedirectToAction("hilton");

        }

        public ActionResult Edit_Ferozson()
        {
            string sr = Request["edit"];
            var Edit = fer_data.ferozsons.First(g => g.trademark == sr);
            return View(Edit);

        }

        public ActionResult Edit_val_Ferozson()
        {
            string sr = Request["trademark"];
            var Edit = fer_data.ferozsons.First(g => g.trademark == sr);

            Edit.generic = Request["generic"];
            Edit.cure = Request["cure"];
            Edit.potency = Request["potency"];
            fer_data.SubmitChanges();
            return RedirectToAction("ferozsons");

        }
    }
}