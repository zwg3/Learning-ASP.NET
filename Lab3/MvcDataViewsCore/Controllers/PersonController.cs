using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcDataViewsCore.Models;

namespace MvcDataViewsCore.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> people = new();
        // GET: PersonController
        public ActionResult Index()
        {
            return View(people);
        }

        // GET: PersonController/Details/5
        public ActionResult Details(Person p)
        {
            return View(p);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person p)
        {
            try
            {
                if (!ModelState.IsValid)
                {                    
                return View("Create", p);
                }
                people.Add(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            Person p = new Person();
            foreach (Person pn in people)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Age = pn.Age;
                    p.Id = pn.Id;
                    p.Phone = pn.Phone;
                    p.Email = pn.Email;
                }
            }            
            return View(p);
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Person p)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", p);
            }
            foreach (Person pn in people)
            {
                if (pn.Id == p.Id)
                {
                    pn.Name = p.Name;
                    pn.Age = p.Age;
                    pn.Id = p.Id;
                    pn.Phone = p.Phone;
                    pn.Email = p.Email;
                }
            }
            return RedirectToAction("Index");
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            Person p = new Person();
            foreach (Person pn in people)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Age = pn.Age;
                    p.Id = pn.Id;
                    p.Phone = pn.Phone;
                    p.Email = pn.Email;
                }
            }
            return View(p);

        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Person p)
        {
            try
            {
                foreach (Person pn in people)
                {
                    if (pn.Id == p.Id)
                    {
                        people.Remove(pn);
                        return RedirectToAction("Index");
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(p);
            }

        }
    }
}
