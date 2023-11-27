using Microsoft.AspNetCore.Mvc;
using SXDatalaag;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Veiling2BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeilingController : ControllerBase
    {
        private DatabaseVeilingContext _mdc;

        public VeilingController(DatabaseVeilingContext mdc) 
        {
            _mdc = mdc;
        }


        // GET: api/<VeilingController>
        [HttpGet]
        public IEnumerable<Veiling> Get()
        {
            Veiling veiling = new Veiling();
            veiling.StartDatumTijd = new DateTime(2023, 12, 1);
            veiling.Duratie = 5;
            veiling.OpeningsBod = 200;
            veiling.MinimumBod = 250;
            veiling.LaatsteBod = 299;
            _mdc.Add(veiling);
            _mdc.SaveChanges();
            return _mdc.Veiling;
        }

        // GET api/<VeilingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VeilingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VeilingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VeilingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
