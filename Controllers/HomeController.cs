using _123Pay.Models;
using _123Pay.Repositories;
using _123Pay.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPaymentRequestRepository paymentRequestRepository;
        private readonly ILogger<HomeController> logger;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(IPaymentRequestRepository _paymentRequestRepository,
                            IWebHostEnvironment _hostingEnvironment,
                            ILogger<HomeController> _logger)
        {
            this.hostingEnvironment = _hostingEnvironment;
            paymentRequestRepository = _paymentRequestRepository;
            logger = _logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = paymentRequestRepository.GetAllPaymentRequests();
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = paymentRequestRepository.GetPaymentRequest(id);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
