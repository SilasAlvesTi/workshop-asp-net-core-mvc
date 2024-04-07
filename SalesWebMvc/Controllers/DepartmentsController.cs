using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    [Route("[controller]")]
    public class DepartmentsController : Controller
    {
        private readonly ILogger<DepartmentsController> _logger;

        public DepartmentsController(ILogger<DepartmentsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Department> list = [
                new Department { Id = 1, Name = "Eletronics"}, 
                new Department { Id = 2, Name = "Fashion"}
            ];

            return View(list);
        }
    }
}