using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThuVien.ADO;

namespace QLThuVien.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult Index()
        {
            DAOBanSaoSach lh = new DAOBanSaoSach();
            DAOBanSaoSach hh = new DAOBanSaoSach();
            ViewBag.hh = hh.getAll();
            ViewBag.lh = lh.getAll();
            return View();
        }
    }
}