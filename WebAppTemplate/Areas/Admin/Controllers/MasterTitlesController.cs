using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using WebAppTemplate.Extensions;
using WebAppTemplate.Models;
using WebAppTemplate.Repositories;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterTitlesController : Controller
    {
        IRepository<MasterTitles> Repository;

        public MasterTitlesController(IRepository<MasterTitles> repository)
        {
            Repository = repository;
        }

        // GET: MasterTitlesController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterTitlesFullViewModel { List = data };
            return View(obj);
        }


        // POST: MasterTitlesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterTitlesViewModel collection)
        {
            try
            {
                var allData = Repository.GetAll();
                if (!string.IsNullOrEmpty(collection.Keyword) && allData.Any(x => x.Keyword == collection.Keyword && x.Id != collection.Id))
                {
                    ModelState.AddModelError("", "Keyword already exists.");
                    return Json(new { success = false, message = "Keyword already exists." });
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
                    return Json(new { success = true });
                }
            }
            catch
            {
                return Json(new { success = false, message = "Keyword already exists." });
            }
        }



        // POST: MasterTitlesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterTitlesFullViewModel collection)
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

