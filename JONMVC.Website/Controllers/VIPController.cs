﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JONMVC.Website.Models.Utils;
using JONMVC.Website.ViewModels.Views;

namespace JONMVC.Website.Controllers
{
    [ExitHttpsIfNotRequired]
    public class VIPController : Controller
    {
        //
        // GET: /VIP/

        public ActionResult Index()
        {
            return RedirectToAction("Club");
        }

        public ActionResult Club()
        {
            return View(new EmptyViewModel());
        }
    }
}
