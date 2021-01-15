using System;
using System.Web.Mvc;
using BlogSpot.Models.DB;
using System.Collections.Generic;
using BlogSpot.Models.Parameters;
namespace BlogSpot.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult BlogDetail()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetUserInfo(ParamGet model)
        {
            try
            {
                List<PramUserInfo> userInfo = Users.GetInfo(model);
                if(userInfo.Count > 0)
                {
                    return Json(new { Result = 1, data = userInfo }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { Result = 1, data = "Không tìm thấy thông tin." }, JsonRequestBehavior.AllowGet);
                }
            }
            catch(Exception ex)
            {
                return Json(new { Result = -1, Message = ex.Message}, JsonRequestBehavior.AllowGet);
            }
        }
    }
}