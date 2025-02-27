﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project_.NET.Controllers
{
    public class TestDriveController : Controller
    {
        // GET: TestDriveController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestDriveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestDriveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestDriveController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestDriveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestDriveController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestDriveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestDriveController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
