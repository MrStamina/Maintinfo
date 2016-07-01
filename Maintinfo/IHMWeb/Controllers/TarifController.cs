using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityDal;
using System.Windows.Forms;

namespace IHMWeb.Controllers
{
    public class TarifController : Controller
    {
        // GET: Tarif
        private MaintinfoCodeFirst _context;

        public TarifController()
        {
            _context = new MaintinfoCodeFirst();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Save(Tarif tarif)
        {
            _context.Tarifs.Add(tarif);
            _context.SaveChanges();
            return RedirectToAction("Index","Tarif");
        }
        
    }
}