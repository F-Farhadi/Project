using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace Sample01_OnlineShoping.Controllers
{
    public class ProductController : Controller
    {

        #region [- ctor -]
        public ProductController()
        {

        }
        #endregion

        #region [- prop -]
        public Models.ViewModels.ProductViewModel Refproductviewmodel { get; set; }
        #endregion

        #region [- Index -]
        public async Task<IActionResult> Index()
        {
            var q = Refproductviewmodel.FillGrid();
            return View(await q);
        }
        #endregion

        #region [- Create -]

        #region [- GET -]
        public async Task<IActionResult> Create()
        {
            ViewBag.ProductCategory = new SelectList(Refproductviewmodel.GetCategory(), "id", "Title");
            return View();

        }
        #endregion

        #region [- Post -]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,Code,CtegoryRef,UnitePice")] DTO.DTOProductController product)
        {

            Refproductviewmodel.Save(product);
            return RedirectToAction(nameof(Index));
        }
        #endregion 
        #endregion





    }
}
