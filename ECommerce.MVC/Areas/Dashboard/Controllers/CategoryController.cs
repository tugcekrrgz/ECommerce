﻿using ECommerce.BLL.AbstractServices;
using ECommerce.Entity.Entity;
using ECommerce.MVC.Areas.Dashboard.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) 
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View(_categoryService.GetAllCategories());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryVM categoryVM )
        {
            if (ModelState.IsValid)
            {
                var category = new Category
                {
                    CategoryName = categoryVM.CategoryName,
                    Description = categoryVM.Description,
                };
                var result=_categoryService.Create(category);

                //todo: result içerisinden dönen değer başarılı mı başarısız mı bilinmiyor. Bu yüzden dönene mesajlara ait bir enum oluşturulsa daha efektif olur.
                TempData["Result"] = result;

                return RedirectToAction("Index");
            }
            else
            {
                return View(categoryVM);
            }            
        }

        
        public IActionResult Update(int id)
        {
            var category=_categoryService.GetById(id);
            var updated = new CategoryUpdateVM
            {
                Id = category.Id,
                CategoryName=category.CategoryName,
                Description=category.Description,
            };

            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(CategoryUpdateVM updated)
        {
            if (ModelState.IsValid)
            {
                var categoryUpdate = new Category
                {
                    Id = updated.Id,
                    CategoryName = updated.CategoryName,
                    Description = updated.Description,
                    Status = Entity.Enum.Status.Updated
                };

                var result = _categoryService.Update(categoryUpdate);
                TempData["Result"] = result;
                return RedirectToAction("Index");
            }
            else
            {
                return View(updated);
            }            
        }


        public IActionResult Delete(int id)
        {
            //todo: Silmek istediğinize emin misiniz diye sor ve cevaba göre sil.
            var category = _categoryService.GetById(id);
            category.Status = Entity.Enum.Status.Deleted;

            var result=_categoryService.Delete(id);
            TempData["Result"] = result;
            return RedirectToAction("Index");
        }


    }
}
