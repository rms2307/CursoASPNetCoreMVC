﻿using CursoASPNetCoreMVC.Models;
using CursoASPNetCoreMVC.Models.ViewModels;
using CursoASPNetCoreMVC.Services;
using CursoASPNetCoreMVC.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace CursoASPNetCoreMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var sellers = _sellerService.FindAll();
            return View(sellers);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var deps = _departmentService.FindAll();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = deps };
                return View(viewModel);
            }

            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Error), new { message = "Id not provided" });

            var obj = _sellerService.FindById(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), new { message = "Id not found" });

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Error), new { message = "Id not provided" });

            var obj = _sellerService.FindById(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), new { message = "Id not found" });

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Error), new { message = "Id not provided" });

            var obj = _sellerService.FindById(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), new { message = "Id not found" });

            List<Department> list = _departmentService.FindAll();
            SellerFormViewModel viewModel =
                new SellerFormViewModel { Seller = obj, Departments = list };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var deps = _departmentService.FindAll();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = deps };
                return View(viewModel);
            }
            if (id != seller.Id) return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            try
            {
                _sellerService.Update(seller);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
