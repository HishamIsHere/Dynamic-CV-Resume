using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Extensions;
using WebAppTemplate.Models;
using WebAppTemplate.Repositories;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterFactsController : Controller
    {
        IRepository<MasterFacts> Repository;

        public MasterFactsController(IRepository<MasterFacts> repository)
        {
            Repository = repository;
        }

        // GET: MasterFactsController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterFactsFullViewModel { List = data };
            return View(obj);
        }


        // POST: MasterFactsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterFactsViewModel collection)
        {
            try
            {
                if (collection.Id == 0)
                {
                    var data = collection.ToModel();
                    data.CreatedBy = User.Identity?.Name;
                    Repository.Add(data);
                }
                else
                {
                    var data = collection.ToModel();
                    data.UpdatedBy = User.Identity?.Name;
                    Repository.Update(data);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // POST: MasterFactsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterFactsFullViewModel collection)
        {
            try
            {
                Repository.Delete(collection.DeleteId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
