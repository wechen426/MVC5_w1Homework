using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCw1Homework.Models;

namespace MVCw1Homework.Controllers
{
    public class 客戶資料統計Controller : Controller
    {
        private 客戶資料Entities1 db = new 客戶資料Entities1();

        // GET: 客戶資料統計
        public ActionResult Index()
        {
            return View(db.View_客戶資料統計.ToList());
        }

        // GET: 客戶資料統計/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    View_客戶資料統計 view_客戶資料統計 = db.View_客戶資料統計.Find(id);
        //    if (view_客戶資料統計 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(view_客戶資料統計);
        //}

        //// GET: 客戶資料統計/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: 客戶資料統計/Create
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "客戶Id,客戶名稱,聯絡人數量,銀行帳戶數量")] View_客戶資料統計 view_客戶資料統計)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.View_客戶資料統計.Add(view_客戶資料統計);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(view_客戶資料統計);
        //}

        //// GET: 客戶資料統計/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    View_客戶資料統計 view_客戶資料統計 = db.View_客戶資料統計.Find(id);
        //    if (view_客戶資料統計 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(view_客戶資料統計);
        //}

        //// POST: 客戶資料統計/Edit/5
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "客戶Id,客戶名稱,聯絡人數量,銀行帳戶數量")] View_客戶資料統計 view_客戶資料統計)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(view_客戶資料統計).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(view_客戶資料統計);
        //}

        //// GET: 客戶資料統計/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    View_客戶資料統計 view_客戶資料統計 = db.View_客戶資料統計.Find(id);
        //    if (view_客戶資料統計 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(view_客戶資料統計);
        //}

        //// POST: 客戶資料統計/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    View_客戶資料統計 view_客戶資料統計 = db.View_客戶資料統計.Find(id);
        //    db.View_客戶資料統計.Remove(view_客戶資料統計);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
