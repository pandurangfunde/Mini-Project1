using EmployeeS.Data;
using EmployeeS.Models;
using EmployeeS.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeS.Controllers
{
    public class EmployyesControler : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public EmployyesControler(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employees()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                Department = addEmployeeRequest.Department,
                DateOfBirth = addEmployeeRequest.DateOfBirth,
            };
             await mvcDemoDbContext.Employee1.AddAsync(employee);
                await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }
    }
}
