using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewProject1Crud.Repos.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NewProject1Crud.Models;

namespace NewProject1Crud.Controllers
{
    public class UserController : Controller
    {
       
        private Databasefile Conn;
        public UserController(Databasefile Context)
        {
            Conn = Context;
        }
            public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public string GetUser()
        {
            var its = Conn.UsersDetails.ToList();
            var result = JsonConvert.SerializeObject(new { data = its });
            return result;
        }
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserData user)
        {
            var dit = Conn.UsersDetails.Add(user);
            Conn.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Deletedetails()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UpdateDetails()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateDetail()
        {
            return View();
        }
    }
}
