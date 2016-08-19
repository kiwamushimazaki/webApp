using System.Web.Mvc;
using WebApplication1.Models;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    public class BeginController : Controller
    {
        private MvcBasicContext db = new MvcBasicContext();
        private MvcBasicContext2 db2 = new MvcBasicContext2();
        //GET: Begin
        //public ActionResult Index()
        //{
        //    return Content("こんにちは、世界！");
        //}
        public ActionResult　Show()
        {
            ViewBag.Message = "こんにちは、世界！";
            return View();
        }
        public ActionResult List()
        {
            return View(db.Members);
        }
        public BeginController()
        {
            db.Database.Log = sql =>
            {
                Debug.Write(sql);
            };
        }
        public ActionResult List2()
        {
            return View(db2.Incomes);
        }
       
    }
}