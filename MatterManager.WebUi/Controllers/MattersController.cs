using System.Threading.Tasks;
using System.Web.Mvc;
using MatterManager.WebUi.Managers;
using MatterManager.WebUi.Models;
using MatterManager.WebUi.Repositories;

namespace MatterManager.WebUi.Controllers
{
    public class MattersController : Controller
    {
        private MatterRepository repository = new MatterRepository();

        // GET: Matters
        public ActionResult Index()
        {
            var matters = repository.GetMatters();
            return View(matters);
        }

        // GET: Matters/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Matters/Create
        [HttpPost]
        public async Task<ActionResult> Create(Matter matter)
        {
            var requestHandler = new RequestManager();

            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                   requestHandler.CreateRequest(matter);

                    repository.Save(matter);

                    return RedirectToAction("Index");
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Matters/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Matters/Edit/5
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

        // GET: Matters/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Matters/Delete/5
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