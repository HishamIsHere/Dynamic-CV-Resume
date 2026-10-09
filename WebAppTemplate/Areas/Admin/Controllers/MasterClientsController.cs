using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTemplate.Extensions;
using WebAppTemplate.Helpers.File;
using WebAppTemplate.Models;
using WebAppTemplate.Repositories;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterClientsController : Controller
    {
        IRepository<MasterClients> Repository;
        IFileHelper FileHelper;
        public MasterClientsController(IRepository<MasterClients> repository, IFileHelper fileHelper)
        {
            Repository = repository;
            FileHelper = fileHelper;
        }

        // GET: MasterClientsController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterClientsFullViewModel { List = data };
            return View(obj);
        }


        // POST: MasterClientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterClientsViewModel collection)
        {
            try
            {
                if (collection.Id == 0)
                {
                    var data = collection.ToModel();
                    data.CreatedBy = User.Identity?.Name;
                    data.ImageURL = FileHelper.SaveImage(collection.Imagefile, "MasterAboutImage");
                    if (data.ImageURL != "Error")
                    {
                        Repository.Add(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Image Is Required");
                        return View(collection);
                    }
                }
                else
                {
                    var data = collection.ToModel();
                    data.UpdatedBy = User.Identity?.Name;
                    data.ImageURL = FileHelper.SaveImage(collection.Imagefile, "MasterAboutImage");
                    if (data.ImageURL != "Error")
                    {
                        Repository.Update(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Image Is Required");
                        return View(collection);
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // POST: MasterClientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterClientsFullViewModel collection)
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
