using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PartiuJunto.Web.Controllers
{
    public class PedidosController : Controller
    {
        public IActionResult Carrossel()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
        }
        public IActionResult Resumo()
        {
            return View();
        }


        // GET: api/Pedido
        [Produces("application/json")]
        [Route("api/Pedido")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pedido/5
        [Produces("application/json")]
        [Route("api/Pedido")]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pedido
        [Produces("application/json")]
        [Route("api/Pedido")]
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pedido/5
        [Produces("application/json")]
        [Route("api/Pedido")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [Produces("application/json")]
        [Route("api/Pedido")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
