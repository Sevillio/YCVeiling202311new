using Microsoft.AspNetCore.Mvc;
using SXDatalaag;
using SXDatalaag.Migrations;
using Veilingstuk = SXDatalaag.Veilingstuk;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Veiling2BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeilingstukController : ControllerBase
    {
        private DatabaseVeilingContext _mdc;

        public VeilingstukController(DatabaseVeilingContext mdc)
        {
            _mdc = mdc;
        }
        // GET: api/<VeilingstukController>
        [HttpGet]
        public IEnumerable<Veilingstuk> Get()
        {
           Veilingstuk veilingstuk = new Veilingstuk();
           Account account = new Account();
            veilingstuk.StukName = "Mona lisa";
            veilingstuk.Aanbieder = account.Name;
            veilingstuk.Categorie = "Art";
            veilingstuk.Hoogte = 4;
            veilingstuk.Beschrijving = "Gemaakt door leonardo Davinci";
            veilingstuk.Lengte = 4;
            veilingstuk.Gewicht = 1;
            veilingstuk.Width = 3;
            
            return _mdc.Veilingstuk;
        }
        


        // GET api/<VeilingstukController>/5
        [HttpGet("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VeilingstukController>
        [HttpPost]
        public void Post([FromBody] Veilingstuk value)
        {
            _mdc.Add(value);
            _mdc.SaveChanges();

            return;
        }

        // PUT api/<VeilingstukController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Veilingstuk value)
        {
                
        }

        // DELETE api/<VeilingstukController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mdc.Remove(id);
        }
    }
}
