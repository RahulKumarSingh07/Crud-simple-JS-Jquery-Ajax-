using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewProject1Crud.Repos.Services;
using Microsoft.EntityFrameworkCore;
using NewProject1Crud.Models;
using Microsoft.AspNetCore.Hosting;
using NewProject1Crud.Repos.Interface;



namespace NewProject1Crud.Controllers
{
    public class ItemsController : Controller
    {
        //public IItemsData Data { get; }
        //public ItemsController(IItemsData data)
        //{
        //    Data = data;
        //}
        private Databasefile Conn1;

        [Obsolete]
        public IHostingEnvironment Enviroment { get; }
        [Obsolete]
        public ItemsController(Databasefile Context1, IHostingEnvironment enviroment)
        {
            this.Conn1 = Context1;
            Enviroment = enviroment;



        }
        public IActionResult Index()
        {
            //var qw = Data.GetItemsDeta();
            //return View(qw);
            var its = Conn1.ItmesDetails.ToList();
            return View(its);
        }
        public IActionResult Create()
        {
                      return View();
        }
        [Obsolete]
        [HttpPost]
        public IActionResult Create1(ItemsData Data1)
        {
            //Data.Create(Data1);
            //return RedirectToAction("Index");
            var img = Request.Form.Files;
            string dbpath = string.Empty;
            if (img.Count > 0)
            {
                string path = Enviroment.WebRootPath;
                string fullpath = Path.Combine(path, "Images", img[0].FileName);
                dbpath = "Images/" + img[0].FileName;
                FileStream stream = new FileStream(fullpath, FileMode.Create);
                img[0].CopyTo(stream);

            }
            Data1.Images = dbpath;
            Conn1.ItmesDetails.Add(Data1);
            Conn1.SaveChanges();
            return RedirectToAction("Index");
        }
      
        public IActionResult Deletedetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var code = Conn1.ItmesDetails.SingleOrDefault(x => x.Id == id);
            if (code == null)
            {
                return NotFound();
            }
            Conn1.ItmesDetails.Remove(code);
            Conn1.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult UpdateDetails(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = Conn1.ItmesDetails.Find(id);

            if (obj==null) {
                return NotFound();
            }
            return View(obj);
        }
        [Obsolete]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateDetails(ItemsData Data2)
        {
            if (ModelState.IsValid)
            {
                //var img = Request.Form.Files;
                //if (img!= null )
                
                //{
                //    string path = Enviroment.WebRootPath;
                //    string filename = Path.GetFileName(Data2 Images);
                //    string filepath = Path.Combine(Server.MapPath(path, filename);
                //    Data2.SaveAs(filepath);

                //}
                //Data2.Images = dbpath;
                Conn1.ItmesDetails.Update(Data2);
                Conn1.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Data2);
        }


    }
}
