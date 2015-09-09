using MyMVCAutofac.Core.Interface;
using MyMVCAutofac.Core.Model;
using MyMVCAutofac.Data.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCAutofacPractice.Controllers
{
    public class MyPageController : Controller
    {

        private ISqlRepository _repository { get; set; }

        /// <summary>
        /// Construct DI Repository 
        /// </summary>
        /// <param name="repo"></param>
        public MyPageController(ISqlRepository repo)
        {
            _repository = repo;
        }

        // GET: MyPage
        public ActionResult Index()
        {
            var teams = _repository.GetAll<Supplier>().ToList();
            return View(teams);
        }

        // GET: MyPage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyPage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyPage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyPage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyPage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyPage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyPage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
