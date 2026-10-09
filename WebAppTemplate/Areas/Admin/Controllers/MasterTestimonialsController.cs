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
    public class MasterTestimonialsController : Controller
    {
        IRepository<MasterTestimonials> Repository;
        IFileHelper FileHelper;
        public MasterTestimonialsController(IRepository<MasterTestimonials> repository, IFileHelper fileHelper)
        {
            Repository = repository;
            FileHelper = fileHelper;
        }

        // GET: MasterTestimonialsController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterTestimonialsFullViewModel { List = data };
            return View(obj);
        }


        // POST: MasterTestimonialsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterTestimonialsViewModel collection)
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



        // POST: MasterTestimonialsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterTestimonialsFullViewModel collection)
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
