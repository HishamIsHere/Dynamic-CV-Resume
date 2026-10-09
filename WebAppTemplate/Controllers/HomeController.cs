using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppTemplate.Extensions;
using WebAppTemplate.Models;
using WebAppTemplate.Repositories;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository<MasterAbout> MasterAboutRepository;
        IRepository<MasterSocialMedia> MasterSocialMediaRepository;
        IRepository<MasterPositions> MasterPositionsRepository;
        IRepository<MasterTitles> MasterTitlesRepository;
        IRepository<MasterServices> MasterServicesRepository;
        IRepository<MasterTestimonials> MasterTestimonialsRepository;
        IRepository<MasterClients> MasterClientsRepository;
        IRepository<MasterPlans> MasterPlansRepository;
        IRepository<MasterPlanItems> MasterPlanItemsRepository;
        IRepository<MasterFacts> MasterFactsRepository;
        IRepository<MasterEducation> MasterEducationRepository;
        IRepository<MasterExperience> MasterExperienceRepository;
        IRepository<MasterSkills> MasterSkillsRepository;
        IRepository<MasterCertificates> MasterCertificatesRepository;
        IRepository<MasterCategory> MasterCategoryRepository;
        IRepository<MasterPortfolio> MasterPortfolioRepository;
        IRepository<MasterContactUs> MasterContactUsRepository;
        IRepository<MasterTransactionContactUs> MasterTransactionContactUsRepository;
        public HomeController(ILogger<HomeController> logger, IRepository<MasterAbout> masterAboutRepository, IRepository<MasterSocialMedia> masterSocialMediaRepository, IRepository<MasterPositions> masterPositionsRepository, IRepository<MasterTitles> masterTitlesRepository, IRepository<MasterServices> masterServicesRepository, IRepository<MasterTestimonials> masterTestimonialsRepository, IRepository<MasterClients> masterClientsRepository, IRepository<MasterPlans> masterPlansRepository, IRepository<MasterPlanItems> masterPlanItemsRepository, IRepository<MasterFacts> masterFactsRepository, IRepository<MasterEducation> masterEducationRepository, IRepository<MasterExperience> masterExperienceRepository, IRepository<MasterSkills> masterSkillsRepository, IRepository<MasterCertificates> masterCertificatesRepository, IRepository<MasterCategory> masterCategoryRepository, IRepository<MasterPortfolio> masterPortfolioRepository, IRepository<MasterContactUs> masterContactUsRepository, IRepository<MasterTransactionContactUs> masterTransactionContactUsRepository)
        {
            _logger = logger;
            MasterAboutRepository = masterAboutRepository;
            MasterSocialMediaRepository = masterSocialMediaRepository;
            MasterPositionsRepository = masterPositionsRepository;
            MasterTitlesRepository = masterTitlesRepository;
            MasterServicesRepository = masterServicesRepository;
            MasterTestimonialsRepository = masterTestimonialsRepository;
            MasterClientsRepository = masterClientsRepository;
            MasterPlansRepository = masterPlansRepository;
            MasterPlanItemsRepository = masterPlanItemsRepository;
            MasterFactsRepository = masterFactsRepository;
            MasterEducationRepository = masterEducationRepository;
            MasterExperienceRepository = masterExperienceRepository;
            MasterSkillsRepository = masterSkillsRepository;
            MasterCertificatesRepository = masterCertificatesRepository;
            MasterCategoryRepository = masterCategoryRepository;
            MasterPortfolioRepository = masterPortfolioRepository;
            MasterContactUsRepository = masterContactUsRepository;
            MasterTransactionContactUsRepository = masterTransactionContactUsRepository;
        }

        public IActionResult Index()
        {
            var data = new HomeViewModel
            {
                MasterAbout = MasterAboutRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterSocialMedia = MasterSocialMediaRepository.GetAllClient()?.ToViewModelList(),
                MasterPositions = MasterPositionsRepository.GetAllClient()?.ToViewModelList(),
                MasterTitles = MasterTitlesRepository.GetAllClient()?.ToViewModelList(),
                MasterServices = MasterServicesRepository.GetAllClient()?.ToViewModelList(),
                MasterTestimonials = MasterTestimonialsRepository.GetAllClient()?.ToViewModelList(),
                MasterClients = MasterClientsRepository.GetAllClient()?.ToViewModelList(),
                MasterPlans = MasterPlansRepository.GetAllClient()?.ToViewModelList(),
                MasterPlanItems = MasterPlanItemsRepository.GetAllClient()?.ToViewModelList(),
                MasterFacts = MasterFactsRepository.GetAllClient()?.ToViewModelList(),
                MasterEducation = MasterEducationRepository.GetAllClient()?.ToViewModelList(),
                MasterExperience = MasterExperienceRepository.GetAllClient()?.ToViewModelList(),
                MasterSkills = MasterSkillsRepository.GetAllClient()?.ToViewModelList(),
                MasterCertificates = MasterCertificatesRepository.GetAllClient()?.ToViewModelList(),
                MasterCategory = MasterCategoryRepository.GetAllClient()?.ToViewModelList(),
                MasterPortfolio = MasterPortfolioRepository.GetAllClient()?.ToViewModelList(),
                MasterContactUs = MasterContactUsRepository.GetAllClient()?.ToViewModelList(),
            };
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SendContactMessage(MasterTransactionContactUs model)
        {
            ModelState.Remove("CreatedBy");
            ModelState.Remove("UpdatedBy");
            ModelState.Remove("CreatedDate");
            ModelState.Remove("UpdatedDate");

            if (ModelState.IsValid)
            {
                model.SendingDate = DateTime.Now;
                model.IsReplied = false;

                MasterTransactionContactUsRepository.Add(model);

                TempData["Sucess"] = "Your message has been Sent successfully";
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
