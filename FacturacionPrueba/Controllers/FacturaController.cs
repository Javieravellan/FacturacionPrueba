using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturacionPrueba.Models;
using FacturacionPrueba.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FacturacionPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly FacturaRepository repo = new FacturaRepository();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return Ok(repo.GetProductos());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
