using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SXDatalaag;
using SXDatalaag.Migrations;
using System;
using System.Diagnostics;
using System.Threading;
using Veiling2BE;
using static SXDatalaag.Veiling;
using Veilingstuk = SXDatalaag.Veilingstuk;

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
            veiling.StartDatumTijd = new DateTime();
            veiling.EndDatumtijd = new DateTime();
            
            veiling.OpeningsBod = 200;
                if (veiling.StartDatumTijd < DateTime.Now)
                {
                    veiling.Status = Veilingstatus.Scheduled.ToString();
                }
                else if (veiling.StartDatumTijd >= DateTime.Now && DateTime.Now <= veiling.EndDatumtijd)
                {
                    veiling.Status = Veilingstatus.Open.ToString();
                }
                else
                {
                    veiling.Status = Veilingstatus.Closed.ToString();
                }
            veiling.Status = "";
            Veilingstuk veilingstuk = new();
            veiling.VeilingstukId = veilingstuk.Id;

            _mdc.SaveChanges();
            return _mdc.Veiling;
        }

        [HttpPost("abc/{vsId}")]
        public IEnumerable<Veiling> Getveiling([FromBody] Veiling veiling)
        {

            _mdc.Add(veiling);
            _mdc.SaveChanges();
            return _mdc.Veiling;

        }

        // GET api/<VeilingController>/5
        [HttpGet("{id:int}")]
        public string Get(int id, Veiling veiling)
        {

            return "value";
        }


        // POST api/<VeilingController>
        [HttpPost]
        public void Post([FromBody] Veiling veiling)
        {


            _mdc.Add(veiling);
            _mdc.SaveChanges();

            return;
        }

        // PUT api/<VeilingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Veiling veiling)
        {
            var existingVeiling = _mdc.Find<Veiling>(id);
            if (existingVeiling != null)
            {
                _mdc.Entry(existingVeiling).CurrentValues.SetValues(veiling);
                _mdc.SaveChanges();
            }
            return;
        }

        // DELETE api/<VeilingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var veiling = _mdc.Find<Veiling>(id);
            if (veiling != null)

            {
                _mdc.Remove(id);
                _mdc.SaveChanges();
            }
            return;
        }
    }
}