using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID = "2"397860,

namespace myMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{storeId}")]
        public Store Get(string storeId)
        {
            _logger.LogInformation(storeId);
            return new Store
            {
                id = "2",
                partnerId = "2",
                name = "2",
                status = "2",
                openingDate = DateTime.Now,
                closingDate = DateTime.Now.AddDays(1),
                generalNotification = "2",
                openingNotification = "2",
                priorityNotificationText = "2"
            };
        }
    }
}
