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
    public class MasterSocialMediaController : Controller
    {
        IRepository<MasterSocialMedia> Repository;

        public MasterSocialMediaController(IRepository<MasterSocialMedia> repository)
        {
            Repository = repository;
        }

        // GET: MasterSocialMediaController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterSocialMediaFullViewModel { List = data };
            return View(obj);
        }


        // POST: MasterSocialMediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterSocialMediaViewModel collection)
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



        // POST: MasterSocialMediaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterSocialMediaFullViewModel collection)
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
