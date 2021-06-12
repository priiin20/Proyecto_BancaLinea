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
    public class Consulta_SaldoController : ApiController
    {
        private Model2 db = new Model2();

        // GET: api/Consulta_Saldo
        public IQueryable<Consulta_Saldo> GetConsulta_Saldo()
        {
            return db.Consulta_Saldo;
        }

        // GET: api/Consulta_Saldo/5
        [ResponseType(typeof(Consulta_Saldo))]
        public IHttpActionResult GetConsulta_Saldo(int id)
        {
            Consulta_Saldo consulta_Saldo = db.Consulta_Saldo.Find(id);
            if (consulta_Saldo == null)
            {
                return NotFound();
            }

            return Ok(consulta_Saldo);
        }

        // PUT: api/Consulta_Saldo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutConsulta_Saldo(int id, Consulta_Saldo consulta_Saldo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != consulta_Saldo.pk_id_Consulta_saldo)
            {
                return BadRequest();
            }

            db.Entry(consulta_Saldo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Consulta_SaldoExists(id))
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

        // POST: api/Consulta_Saldo
        [ResponseType(typeof(Consulta_Saldo))]
        public IHttpActionResult PostConsulta_Saldo(Consulta_Saldo consulta_Saldo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Consulta_Saldo.Add(consulta_Saldo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = consulta_Saldo.pk_id_Consulta_saldo }, consulta_Saldo);
        }

        // DELETE: api/Consulta_Saldo/5
        [ResponseType(typeof(Consulta_Saldo))]
        public IHttpActionResult DeleteConsulta_Saldo(int id)
        {
            Consulta_Saldo consulta_Saldo = db.Consulta_Saldo.Find(id);
            if (consulta_Saldo == null)
            {
                return NotFound();
            }

            db.Consulta_Saldo.Remove(consulta_Saldo);
            db.SaveChanges();

            return Ok(consulta_Saldo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Consulta_SaldoExists(int id)
        {
            return db.Consulta_Saldo.Count(e => e.pk_id_Consulta_saldo == id) > 0;
        }
    }
}