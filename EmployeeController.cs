using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NanditaP2.Models;

namespace NanditaP2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
           Employee employee =employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
            /* Employee emp = new Employee()
            {
                EmployeeId=101,
                Name="Nandita",
                Gender="Female",
                City="pune",
                
            };*/


        }
    }
}