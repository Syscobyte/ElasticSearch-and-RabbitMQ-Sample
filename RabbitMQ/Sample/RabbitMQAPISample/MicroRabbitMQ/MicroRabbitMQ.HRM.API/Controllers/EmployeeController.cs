﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbitMQ.HRM.Application.Interfaces;
using MicroRabbitMQ.HRM.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMQ.HRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/Employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(_employeeService.GetEmployees());
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Employee> Get(int id)
        {
            return Ok(_employeeService.GetEmployeeById(id));
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            _employeeService.InsertEmployee(employee);
            return Ok(employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            _employeeService.UpdateEmployee(id, employee);
            return Ok(employee);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _employeeService.DeleteEmployee(id);
        }
    }
}
