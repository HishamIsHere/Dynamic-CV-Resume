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
    public class MasterPlansController : Controller
    {
        IRepository<MasterPlans> Repository;

        public MasterPlansController(IRepository<MasterPlans> repository)
        {
            Repository = repository;
        }

        // GET: MasterPlansController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterPlansFullViewModel { List = data };
            return View(obj);
        }


        // POST: MasterPlansController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterPlansViewModel collection)
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
                TempData["Error"] = $"Error saving record:";
                return RedirectToAction(nameof(Index));
            }
        }



        // POST: MasterPlansController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterPlansFullViewModel collection)
        {
            try
            {
                Repository.Delete(collection.DeleteId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Error"] = $"Error deleting record:";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
