using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WEBPEROJEM.Models.DataContext;
using WEBPEROJEM.Models.Personel;

namespace WEBPEROJEM.Controllers
{
    public class PersonelBilgilerisController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();//veri tabanı bağlantısı

        public ActionResult Index()//verileri listeler
        {
            return View(db.PersonelBilgileris.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.PersonelBilgileris.Add(personelBilgileri);//eğer bilgi varsa personel bilgileri tablosuna bunu ekle 
                db.SaveChanges();//kaydet
                return RedirectToAction("Index");//oluşturduktan sonra ındexe yönlendir yani veirleri listelediğim sayfaya yönlendir.
            }

            return View(personelBilgileri);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            if (personelBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        // GET: PersonelBilgileris/Create
        public ActionResult Create()//Ekleme oluşturma için kullanılıyor.
        {
            return View();
        }

        // GET: PersonelBilgileris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
            if (personelBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(personelBilgileri);
        }

        // POST: PersonelBilgileris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personelBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personelBilgileri);
        }

        // GET: PersonelBilgileris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return HttpNotFound();
            }
            var t = db.PersonelBilgileris.Find(id);

            db.PersonelBilgileris.Remove(t);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // POST: PersonelBilgileris/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);
        //    db.PersonelBilgileris.Remove(personelBilgileri);
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
