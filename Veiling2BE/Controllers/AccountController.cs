using Microsoft.AspNetCore.Mvc;
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
            account.Password = "password";
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
        public void Put(int id, [FromBody] Account updatedAccount)
        {
            try
            {
                var existingAccount = _mdc.Find<Account>(id);

                if (existingAccount == null)
                {
                  NotFound(); // Return a 404 Not Found if the entity with the given ID is not found
                }

                // Explicitly update only the properties you want to allow the client to modify
                existingAccount.Name = updatedAccount.Name;
                existingAccount.Email = updatedAccount.Email;
                existingAccount.Telefoon = updatedAccount.Telefoon;
                existingAccount.Address = updatedAccount.Address;
                existingAccount.Place = updatedAccount.Place;
                existingAccount.Postcode = updatedAccount.Postcode;
                // Update other properties as needed

                _mdc.SaveChanges(true);

                NoContent(); // Return a 204 No Content upon successful update
            }
            catch (Exception ex)
            {
                // Log the exception and return a 500 Internal Server Error response
                // Alternatively, return a more user-friendly error message
                StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var existingaccount = _mdc.Find<Account>(id);
            if (existingaccount != null)
            {
                _mdc.Remove(id);
                _mdc.SaveChanges();
            }
            return;
           
        }
    }
}
