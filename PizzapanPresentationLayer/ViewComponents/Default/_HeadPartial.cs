﻿using Microsoft.AspNetCore.Mvc;
using PizzapanBusinessLayer.Abstract;

namespace PizzapanPresentationLayer.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
