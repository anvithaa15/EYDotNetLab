using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consumewebapiinmvc.Models;

namespace consumewebapiinmvc.repository
{
    interface IemployeeRepository
    {
        Task Add(employee employee);
        Task Update(employee employee);
        Task Delete(string id);
        Task<employee> GetEmployee(string id);
        Task<IEnumerable<employee>> GetEmployees();

    }
}
