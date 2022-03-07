using B_21_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B_21_2.Controllers
{
    public class BaiThiController : Controller
    {
        // GET: BaiThi
        public ActionResult Index()
        {
            //var user = new B_21_2.Models.User();
            var user = new List<User>();
            var user1 = new User();
            user1.Name = "TienAnh";
            user1.Email = "letienanh@gmail.com";
            user1.Address = "DongAnh";
            var user2 = new User();
            user2.Name = "TienAnh1";
            user2.Email = "letienanh@gmail.com";
            user2.Address = "DongAnh";
            var user3 = new User();
            user3.Name = "TienAnh2";
            user3.Email = "letienanh@gmail.com";
            user3.Address = "DongAnh";
            user.Add(user1); 
            user.Add(user2); 
            user.Add(user3);
            //ViewBag.user = user; // Cach1;
            return View(user);//return View(user) Cach2;
        }

        public ActionResult htmlHelperEdemo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult htmlHelperEdemo(string name)
        {
            if (name!="")
            {
                string msg = "Welcome " + name;
                return Content(msg);
            }
            else
            {
                return View();
            }
           
        }
    }
}