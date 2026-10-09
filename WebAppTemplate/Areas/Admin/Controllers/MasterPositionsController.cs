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
    public class MasterPositionsController : Controller
    {
        IRepository<MasterPositions> Repository;

        public MasterPositionsController(IRepository<MasterPositions> repository)
        {
            Repository = repository;
        }

        // GET: MasterPositionsController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterPositionsFullViewModel { List = data };
            return View(obj);
        }
        // POST: MasterPositionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterPositionsViewModel collection)
        {
            try
            {
                var allData = Repository.GetAll();
                if (collection.IsPrimary && allData.Any(x => x.IsPrimary))
                {
                    ModelState.AddModelError("", "Only one position allowed to be primary");
                    return View(collection);
                }
                else
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
            }
            catch
            {
                return View();
            }
        }
        // POST: MasterPositionsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterPositionsFullViewModel collection)
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
