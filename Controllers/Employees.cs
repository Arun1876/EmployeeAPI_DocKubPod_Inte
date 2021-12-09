using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWEBAPI_DK_Interation.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeWEBAPI_DK_Interation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employees : ControllerBase
    {
      static List<Employee> emp = new List<Employee>()
        {
            new Employee {id=1,name="Arun",designation="Software ENgineer", salary=10000000000}
        };
        // GET: api/<Employees>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return emp;
        }

        // GET api/<Employees>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return emp.Find(i=>i.id==id).ToString();
        }

        // POST api/<Employees>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            emp.Add(value);
        }

        // PUT api/<Employees>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            int index = emp.FindIndex(p => p.id == id);
            emp.RemoveAt(index);
            emp.Add(value);
        }

        // DELETE api/<Employees>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = emp.FindIndex(p => p.id == id);
            
            emp.RemoveAt(index);
           
        }
    }
}
