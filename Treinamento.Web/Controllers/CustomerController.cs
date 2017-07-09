﻿using System.Web.Mvc;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Repositories.Services;
using Treinamento.Service.Repositories;

namespace Treinamento.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;

        public CustomerController()
        {
            _service = new CustomerServices();
        }

        public ActionResult Index()
        {
            return View(_service.GetByRange());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                _service.Save(customer);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("DefaultErrorMessage","Falhou alguma coisa.");
                return View(customer);
            }
        }

        protected override void Dispose(bool disposing)
        {
            _service.Dispose();
        }
    }
}