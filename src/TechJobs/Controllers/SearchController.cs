using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }


        public IActionResult Results(string column, searchTerm.Text)
        {
            string searchterm = searchTerm.Text;
            List<Dictionary<string, string>> jobs = JobData.FindByValue(searchterm);
            ViewBag.title =  "";
            ViewBag.jobs = jobs;
            return View("jobs");
        }
        // TODO #1 - Create a Results action method to process 
        // search request and display results

    }
}
