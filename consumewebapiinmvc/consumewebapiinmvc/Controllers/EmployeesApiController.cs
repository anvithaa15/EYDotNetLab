using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using consumewebapiinmvc.repository;
using consumewebapiinmvc.Models;

namespace consumewebapiinmvc.Controllers
{
    public class EmployeesApiController : ApiController
    {
        private readonly IemployeeRepository _iemployeeRepository = new employeeRepository();

        [HttpGet]
        [Route("api/employees/Get")]

        public async Task<IEnumerable<employee>> Get()
        {
            return await _iemployeeRepository.GetEmployees();
        }

        [HttpPost]
        [Route("api/employees/Create")]

        public async Task CreateAsync([FromBody] employee employee)
        {
            if (ModelState.IsValid)
            {
                await _iemployeeRepository.Add(employee);
            }
        }

        [HttpGet]
        [Route("api/employees/Details/{id}")]

        public async Task<employee> Details(string id)
        {
            var result = await _iemployeeRepository.GetEmployee(id);
            return result;
        }

        [HttpPut]
        [Route("api/employees/Edit")]

        public async Task EditAsync([FromBody]employee employee)
        {
            if (ModelState.IsValid)
            {
                await _iemployeeRepository.Update(employee);
            }
        }
        
        [HttpDelete]
        [Route("api/employee/Delete/{id}")]

        public async Task DeleteConfirmedAsync(string id)
        {
            await _iemployeeRepository.Delete(id);
        }
    }
}

