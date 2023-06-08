using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NanditaP2.Models
{
    public class EmployeeContext : System.Data.Entity.DbContext
    {

        public System.Data.Entity.DbSet<Employee> Employees { get; set; }

    }
}