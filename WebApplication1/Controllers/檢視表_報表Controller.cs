using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class 檢視表_報表Controller : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: 檢視表_報表
        public ActionResult Index()
        {
            return View(db.檢視表_報表.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
