using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repayments.Core.Interfaces;

namespace Repayments.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerSummaryController : ControllerBase
    {
        private readonly ILogger<CustomerSummaryController> _logger;
        private readonly ICustomerSummaryService _customerSummaryService;

        public CustomerSummaryController(ILogger<CustomerSummaryController> logger, ICustomerSummaryService customerSummaryService)
        {
            _logger = logger;
            _customerSummaryService = customerSummaryService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var customerSummaries = _customerSummaryService.GetAll();
                return StatusCode(200, customerSummaries);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
