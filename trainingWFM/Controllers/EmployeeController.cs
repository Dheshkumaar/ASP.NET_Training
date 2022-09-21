using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trainingWFM.Abstractions;

namespace trainingWFM.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeesService _employeeService;

        public EmployeeController(IEmployeesService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _employeeService.GetAllEmployees();
            return View(result);
        }
    }
}
