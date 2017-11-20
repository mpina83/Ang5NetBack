using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Angular5Core2.Models;
using Angular5Core2.Services;

namespace Angular5Core2.Controllers
{
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {
        // GET
        [HttpGet("[action]")]
        public IEnumerable<ProductModel> Products()
        {
            return DashboardService.CreateProducts();
        }
    }
}