using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAppBancaLinea.Models;

namespace WebAppBancaLinea.Controllers
{
    public class Consultar_ChequeController : ApiController
    {
        private Model3 db = new Model3();

        // GET: api/Consultar_Cheque
        public IQueryable<Consultar_Cheque> GetConsultar_Cheque()
        {
            return db.Consultar_Cheque;
        }

        // GET: api/Consultar_Cheque/5
        [ResponseType(typeof(Consultar_Cheque))]
        public IHttpActionResult GetConsultar_Cheque(int id)
        {
            Consultar_Cheque consultar_Cheque = db.Consultar_Cheque.Find(id);
            if (consultar_Cheque == null)
            {
                return NotFound();
            }

            return Ok(consultar_Cheque);
        }

        // PUT: api/Consultar_Cheque/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutConsultar_Cheque(int id, Consultar_Cheque consultar_Cheque)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != consultar_Cheque.fk_id_consultar_cheque)
            {
                return BadRequest();
            }

            db.Entry(consultar_Cheque).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Consultar_ChequeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Consultar_Cheque
        [ResponseType(typeof(Consultar_Cheque))]
        public IHttpActionResult PostConsultar_Cheque(Consultar_Cheque consultar_Cheque)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Consultar_Cheque.Add(consultar_Cheque);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = consultar_Cheque.fk_id_consultar_cheque }, consultar_Cheque);
        }

        // DELETE: api/Consultar_Cheque/5
        [ResponseType(typeof(Consultar_Cheque))]
        public IHttpActionResult DeleteConsultar_Cheque(int id)
        {
            Consultar_Cheque consultar_Cheque = db.Consultar_Cheque.Find(id);
            if (consultar_Cheque == null)
            {
                return NotFound();
            }

            db.Consultar_Cheque.Remove(consultar_Cheque);
            db.SaveChanges();

            return Ok(consultar_Cheque);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Consultar_ChequeExists(int id)
        {
            return db.Consultar_Cheque.Count(e => e.fk_id_consultar_cheque == id) > 0;
        }
    }
}