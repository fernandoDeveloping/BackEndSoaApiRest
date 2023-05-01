using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceesoDatos;
using Logica;

namespace REST_Integracion.Controllers
{
    public class ChevroletController : ApiController
    {
        logica_autosChevrolet operaciones = new logica_autosChevrolet();

        // GET: api/Chevrolet
        public List<Autos_Chevrolet> Get()
        {
            return operaciones.SeleccionarAutosChevrolet();
        }

        // GET: api/Chevrolet/5
        public Autos_Chevrolet Get(int id)
        {
            return operaciones.SeleccionarAutoPorID(id);
        }

        // POST: api/Chevrolet
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Chevrolet/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Chevrolet/5
        public void Delete(int id)
        {
        }
    }
}
