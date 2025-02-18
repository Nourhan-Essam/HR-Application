using HRAPPLICATION.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRAPPLICATION.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }


        [HttpPost]
        public ViewResult Employees(Employee employee)
        {
            if (ModelState.IsValid)
            {


                Repository.AddEmployee(employee);
                return View("ConfirmPage", employee);
            }
            else
                return View();
        }
        public ViewResult AllEmployees()
        {
            return View(Repository.GetEmployees().Where(emp => emp.isActive == true));
        }
       
    }
}
