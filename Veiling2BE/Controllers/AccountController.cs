﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SXDatalaag;
using System.Diagnostics.CodeAnalysis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Veiling2BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private DatabaseVeilingContext _mdc;

        public AccountController(DatabaseVeilingContext mdc)
        {
            _mdc = mdc;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            Account account = new Account();
            account.Name = "Sev";
            account.Password = "";
            account.Email = "test@mail.com";
            account.Telefoon = "06xxxxxxxx";
            account.Postcode = "1100";
            account.Place = "Amsterdam";
            account.Address = "teststreet";
            return _mdc.Account;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Account account)
        {
            _mdc.Add(account);
            _mdc.SaveChanges();
            return;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Account acountc)
        {
            _mdc.SaveChanges(true);
            return;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mdc.SaveChanges(true);
            return;
           
        }
    }
}
