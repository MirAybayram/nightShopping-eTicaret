﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MirayBayramETicaret.Models.Siniflar;

namespace MirayBayramETicaret.Controllers
{
    [Authorize]

    public class GaleriController : Controller
    {
        // GET: Galeri

        Context c=new Context();
        public ActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
    }
}