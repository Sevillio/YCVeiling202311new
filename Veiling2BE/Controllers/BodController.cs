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
            bod.MinimumBod = (int)(bod.LaatsteBod * 1.15);
            bod.LaatsteBod = (int) bod.Prijs;
            Veilingstuk veilingstuk = new Veilingstuk();
            bod.id = veilingstuk.Id;
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
        public void Put(int id, [FromBody] Bod Bod)
        {
            var existingBod = _mdc.Find<Bod>(id);

            if (existingBod != null)
            {
                _mdc.Entry(existingBod).CurrentValues.SetValues(Bod);
                _mdc.SaveChanges();
            }
            return;
        }

        // DELETE api/<BodController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var bodToDelete = _mdc.Find<Bod>(id);

            if (bodToDelete != null)
            {
                _mdc.Remove(bodToDelete);
                _mdc.SaveChanges();
            }
            return;
        }
    }
}
