using Microsoft.AspNetCore.Mvc;
using SXDatalaag;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Veiling2BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodController : ControllerBase
    {
        private DatabaseVeilingContext _mdc;

        public BodController(DatabaseVeilingContext mdc)
        {
            _mdc = mdc;
        }

        // GET: api/<BodController>
        [HttpGet]
        public IEnumerable<Bod> Get()
        {
            Bod bod = new Bod();
            bod.Prijs = 0;
            Veiling veiling = new Veiling();
            bod.VeilingId = veiling.Id;
            Account account = new Account();
            bod.AccountId = account.Id;
            return _mdc.Bod;
        }

        // GET api/<BodController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BodController>
        [HttpPost]
        public void Post([FromBody] Bod Bod)
        {
            _mdc.Add(Bod);
            _mdc.SaveChanges();
            return;
        }

        // PUT api/<BodController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BodController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mdc.Remove(id);
            return;
        }
    }
}
