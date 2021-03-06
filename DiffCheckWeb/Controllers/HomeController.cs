﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiffCheckWeb.Models;
using DiffMatchPatch;
using Newtonsoft.Json;

namespace DiffCheckWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public JsonResult ComputeDiff([FromBody]JobModel jobList)//MAPPING CH PROBLEM
        {

             
            List<Diff> diff = new List<Diff>();
            List<Diff> result = new List<Diff>();
            diff_match_patch dmp = new diff_match_patch();

            string title = jobList.JobClass[0].title;
            string newTitle = jobList.JobClass[1].title;

            string oldDescription = jobList.JobClass[0].description;
            string newDescription = jobList.JobClass[1].description;


            diff = dmp.diff_main(title, newTitle,false);
            dmp.diff_cleanupSemantic(diff);



            for (int j = 0; j < diff.Count; j++)
            {
                result.Add(diff[j]);
            }

            //Compare description
            diff = dmp.diff_main(oldDescription, newDescription, false);
            dmp.diff_cleanupSemantic(diff);
            for (int j = 0; j < diff.Count; j++)
            {
                result.Add(diff[j]);
            }
            string output = JsonConvert.SerializeObject(result);

            return Json(output);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
