using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trainingWFM.Models;

namespace trainingWFM.Abstractions
{
    public interface IEmployeesService
    {
        Task<IEnumerable<Employeeswithskills>> GetAllEmployees();
    }
}
