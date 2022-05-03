using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoboCop5.Models;

namespace RoboCop5.Controllers
{
    public class CaseReportController : Controller
    {
        private RoboCopEntities db = new RoboCopEntities();
        // GET: CaseRiport
        public ActionResult Index()
        {
            //CaseRiport riport = new CaseRiport();

            //riport.County = db.Megyek.Select(m => m.MNAME).ToList();
            //riport.City = db.Varosok.Select(v => v.VNAME).ToList();
            //riport.PublicSpaceType = db.KozteruletTipusok.Select(k => k.KNAME).ToList();
            //riport.FaceTypes = db.Arcok.Select(a => a.ARNAME).ToList();
            //riport.HairColors = db.Hajszinek.Select(h => h.HANAME).ToList();
            //riport.WalkingTypes = db.Jarasok.Select(j => j.JANAME).ToList();
            //riport.Heights = db.Magassagok.Select(m=> m.MAINTERVAL).ToList();
            //riport.Weights = db.Sulyok.Select(s => s.SUINTERVAL).ToList();
            //riport.EyeColors = db.Szemszinek.Select(sz => sz.SZENAME).ToList();
            //riport.BodyTypes = db.Termetek.Select(t => t.TENAME).ToList();
            //riport.Tools = db.Targyak.Select(tar => tar.TNAME).ToList();

            return View();
        }

        public ActionResult SaveReport()
        {
            CaseRiport riport = new CaseRiport();

            riport.County = db.Megyek.Select(m => m.MNAME).ToList();
            riport.City = db.Varosok.Select(v => v.VNAME).ToList();
            riport.PublicSpaceType = db.KozteruletTipusok.Select(k => k.KNAME).ToList();
            riport.FaceTypes = db.Arcok.Select(a => a.ARNAME).ToList();
            riport.HairColors = db.Hajszinek.Select(h => h.HANAME).ToList();
            riport.WalkingTypes = db.Jarasok.Select(j => j.JANAME).ToList();
            riport.Heights = db.Magassagok.Select(m => m.MAINTERVAL).ToList();
            riport.Weights = db.Sulyok.Select(s => s.SUINTERVAL).ToList();
            riport.EyeColors = db.Szemszinek.Select(sz => sz.SZENAME).ToList();
            riport.BodyTypes = db.Termetek.Select(t => t.TENAME).ToList();
            riport.Tools = db.Targyak.Select(tar => tar.TNAME).ToList();

            return View();
        }

        [HttpPost]
        public ActionResult SaveReport(string test)
        {
            return View();
        }

    }
}