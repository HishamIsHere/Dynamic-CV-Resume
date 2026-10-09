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
    public class MasterAboutController : Controller
    {
        IRepository<MasterAbout> Repository;
        IFileHelper FileHelper;
        public MasterAboutController(IRepository<MasterAbout> repository, IFileHelper fileHelper)
        {
            Repository = repository;
            FileHelper = fileHelper;
        }

        // GET: MasterAboutController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterAboutFullViewModel { List = data };
            return View(obj);
        }

        // POST: MasterAboutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterAboutViewModel collection)
        {
            try
            {
                if (collection.Id == 0)
                {
                    var data = collection.ToModel();
                    data.CreatedBy = User.Identity?.Name;
                    data.CVURL = FileHelper.SaveDoc(collection.CVFile, "MasterAboutCV");
                    data.ImageURL = FileHelper.SaveImage(collection.Imagefile, "MasterAboutImage");
                    if (data.CVURL != "Error" && data.ImageURL != "Error")
                    {
                        Repository.Add(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Image and CV are Required");
                        return View(collection);
                    }
                }
                else
                {
                    var data = collection.ToModel();
                    data.UpdatedBy = User.Identity?.Name;
                    data.CVURL = FileHelper.SaveDoc(collection.CVFile, "MasterAboutCV");
                    data.ImageURL = FileHelper.SaveImage(collection.Imagefile, "MasterAboutImage");
                    if (data.CVURL != "Error" && data.ImageURL != "Error")
                    {
                        Repository.Update(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Image and CV are Required");
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



        // POST: MasterAboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterAboutFullViewModel collection)
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
