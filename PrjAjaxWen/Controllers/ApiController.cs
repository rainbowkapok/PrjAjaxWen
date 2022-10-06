using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjAjaxWen.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            //Content(單純文字)
            return Content("hi Ajax","text/html",System.Text.Encoding.UTF8);
        }
        public IActionResult first()
        {
            return View();
        }
        public IActionResult AjaxEven()
        {
            return View();
        }
        public IActionResult Sleep()
        {
            System.Threading.Thread.Sleep(5000);
            return Content("睡了5秒", "text/plain");
        }
        public IActionResult Register(Member member)
        {
            return Content(member.Name, "text/plain");
        }

        //public IActionResult Register(Member member, IFormFile File1)
        //{

        //    //todo 將收到會員資料寫進資料庫中
        //    //string info = _host.WebRootPath;
        //    //string info = _host.ContentRootPath
        //    //string info = $"{File1.FileName}-{File1.ContentType}-{File1.Length}";
        //    return Content(member.Name, "text/plain");
        //}
    }
}
