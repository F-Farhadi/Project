using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sample01_OnlineShoping.Controllers
{
    public class ProductCategoryController : Controller
    {
        #region [- ctor -]
        public ProductCategoryController()
        {

        }
        #endregion

        #region [- prop -]
        public Models.ViewModels.ProductCategoryViewModel Refproductcategoryviewmodel { get; set; }

        #endregion


        #region [- Index -]
        public async Task<IActionResult> Index()
        {
            var q = Refproductcategoryviewmodel.FillGrid();
            return View(await q);
        }
        #endregion




        #region [- Create -]

        #region [- GET -]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        #endregion

        #region [- post -]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(include: "id,Title,code")] DTO.DTOCategoryProductController category)
        {
            if (ModelState.IsValid)
            {
                Refproductcategoryviewmodel.Save(category);
                await SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Data Insert Successfully";
        }
        #endregion

        #endregion

        #region  [- Edite -]

        public async Task<IActionResult> Edite(int? id)
        {
            var productcategory = Refproductcategoryviewmodel.ShowDetails(id);
            return View(productcategory);
        }

        //#region [- post -]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Code")] DTO.DTOCategoryProductController category)
        //{
        //    if (id != category.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            Refproductcategoryviewmodel.Edit(category);
        //            await SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ProductExists(product.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CategoryRef"] = new SelectList(_context.CategoryProducts, "Id", "Id", product.CategoryRef);
        //    return View(product);
        //}

        //#endregion 

        #endregion
    }
}
