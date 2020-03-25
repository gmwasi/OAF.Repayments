using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repayments.Core.Interfaces;
using Repayments.Core.Models;

namespace Repayments.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepaymentsController : ControllerBase
    {
        private readonly ILogger<RepaymentsController> _logger;
        private readonly IRepaymentService _repaymentService;

        public RepaymentsController(ILogger<RepaymentsController> logger, IRepaymentService repaymentService)
        {
            _logger = logger;
            _repaymentService = repaymentService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, "Ok");
        }

        [HttpPost]
        public IActionResult Post([FromBody]IEnumerable<RepaymentUpload> repaymentUploads)
        {
            try
            {
                var repayments = _repaymentService.submitPaymentList(repaymentUploads);
                return StatusCode(200, repayments);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}