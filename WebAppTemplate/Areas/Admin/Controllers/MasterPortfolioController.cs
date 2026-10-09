using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppTemplate.Extensions;
using WebAppTemplate.Helpers.File;
using WebAppTemplate.Models;
using WebAppTemplate.Repositories;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterPortfolioController : Controller
    {
        IRepository<MasterPortfolio> MasterPortfolioRepository;
        IRepository<MasterCategory> MasterCategoryRepository;
        IFileHelper FileHelper;

        public MasterPortfolioController(
            IFileHelper fileHelper, IRepository<MasterPortfolio> masterPortfolioRepository, IRepository<MasterCategory> masterCategoryRepository)
        {
            FileHelper = fileHelper;
            MasterPortfolioRepository = masterPortfolioRepository;
            MasterCategoryRepository = masterCategoryRepository;
        }

        // GET: MasterPortfolioController
        public ActionResult Index()
        {
            var data = MasterPortfolioRepository.GetAll().ToViewModelList();
            var categoryEntities = MasterCategoryRepository.GetAll();
            foreach(var item in data)
            {
                item.MasterCategory = categoryEntities.FirstOrDefault(c => c.Id == item.CategoryId)?.Name;
            }
            var categories = categoryEntities.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name,
            }).ToList();


            var obj = new MasterPortfolioFullViewModel
            {
                List = data,
                MasterCategoryList = categories,
            };

            return View(obj);
        }

        // POST: MasterPortfolioController/CreateOrUpdate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterPortfolioViewModel collection)
        {
            if (collection.CategoryId <= 0)
            {
                ModelState.AddModelError("CategoryId", "Please select a valid category.");
                return View(collection);
            }
            try
            {
                if (collection.Id == 0)
                {
                    var data = collection.ToModel();
                    data.CreatedBy = User.Identity?.Name;
                    if (collection.ThumbnailImageFile != null)
                    {
                        data.ThumbnailImageURL = FileHelper.SaveImage(collection.ThumbnailImageFile, "MasterPortfolioImage");
                    }
                    if (collection.ViewImageFile != null)
                    {
                        data.ViewImageURL = FileHelper.SaveImage(collection.ViewImageFile, "MasterPortfolioImage");
                    }
                    if (data.ThumbnailImageURL != "Error")
                    {
                        MasterPortfolioRepository.Add(data);
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
                    if (collection.ThumbnailImageFile != null)
                    {
                        data.ThumbnailImageURL = FileHelper.SaveImage(collection.ThumbnailImageFile, "MasterPortfolioImage");
                    }
                    if (collection.ViewImageFile != null)
                    {
                        data.ViewImageURL = FileHelper.SaveImage(collection.ViewImageFile, "MasterPortfolioImage");
                    }

                    if (data.ThumbnailImageURL != "Error")
                    {
                        MasterPortfolioRepository.Update(data);
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

        // POST: MasterPortfolioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterPortfolioFullViewModel collection)
        {
            try
            {
                MasterPortfolioRepository.Delete(collection.DeleteId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
