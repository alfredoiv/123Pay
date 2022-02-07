using _123Pay.Models;
using _123Pay.Repositories;
using _123Pay.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace _123Pay.Controllers
{
    public class PaymentRequestController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly IPaymentRequestRepository paymentRequestRepository;
        private readonly UserManager<ApplicationUser> userManager;
        public PaymentRequestController(IPaymentRequestRepository _paymentRequestRepository,
                                        IWebHostEnvironment hostingEnvironment,
                                        UserManager<ApplicationUser> _userManager)
        {
            this.hostingEnvironment = hostingEnvironment;
            paymentRequestRepository = _paymentRequestRepository;
            this.userManager = _userManager;
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("~/api/{controller}")]
        public HttpResponseMessage Create([FromBody] PaymentRequestViewModel request)
        {
            try
            {
                paymentRequestRepository.Add(request);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = paymentRequestRepository.GetPaymentRequest(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(PaymentRequestAttachmentViewModel model, IFormFile attachment, string tag)
        {
            if (ModelState.IsValid)
            {
                if (tag == Status.Done && attachment == null)
                {
                    return View("Edit", model);
                }

                if (model.AttachmentFilePath != null)
                {
                    string filePath = Path.Combine(hostingEnvironment.WebRootPath,
                        "images", model.AttachmentFilePath);
                    System.IO.File.Delete(filePath);
                }
                var user = userManager.FindByNameAsync(User.Identity.Name).Result;
                model.AttachmentFilePath = ProcessUploadedFile(attachment);
                paymentRequestRepository.UpdateAttachmentStatus(model.Id, model.AttachmentFilePath ?? "", tag, user.Id);
                return RedirectToAction("Index", "Home");
            }

            return View("Edit", model);
        }

        private string ProcessUploadedFile(IFormFile attachment)
        {
            string uniqueFileName = null;
            if (attachment != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + attachment.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    attachment.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
