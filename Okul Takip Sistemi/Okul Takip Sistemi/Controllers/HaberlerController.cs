﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Okul_Takip_Sistemi.Controllers
{
    public class HaberlerController : Controller
    {
        // GET: Haberler
        public ActionResult Index()
        {
            return View();
        }
    }
}