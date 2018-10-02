using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ForeningsService.Models;

namespace ForeningsService.Controllers
{
    public class AktivitetsController : ApiController
    {
        private Model db = new Model();

        // GET: api/Aktivitets
        public IQueryable<Aktivitet> GetAktivitet()
        {
            return db.Aktivitet;
        }

        // GET: api/Aktivitets/5
        [ResponseType(typeof(Aktivitet))]
        public async Task<IHttpActionResult> GetAktivitet(int id)
        {
            Aktivitet aktivitet = await db.Aktivitet.FindAsync(id);
            if (aktivitet == null)
            {
                return NotFound();
            }

            return Ok(aktivitet);
        }

        // PUT: api/Aktivitets/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAktivitet(int id, Aktivitet aktivitet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aktivitet.AktivitetID)
            {
                return BadRequest();
            }

            db.Entry(aktivitet).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AktivitetExists(id))
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

        // POST: api/Aktivitets
        [ResponseType(typeof(Aktivitet))]
        public async Task<IHttpActionResult> PostAktivitet(Aktivitet aktivitet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Aktivitet.Add(aktivitet);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aktivitet.AktivitetID }, aktivitet);
        }

        // DELETE: api/Aktivitets/5
        [ResponseType(typeof(Aktivitet))]
        public async Task<IHttpActionResult> DeleteAktivitet(int id)
        {
            Aktivitet aktivitet = await db.Aktivitet.FindAsync(id);
            if (aktivitet == null)
            {
                return NotFound();
            }

            db.Aktivitet.Remove(aktivitet);
            await db.SaveChangesAsync();

            return Ok(aktivitet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AktivitetExists(int id)
        {
            return db.Aktivitet.Count(e => e.AktivitetID == id) > 0;
        }
    }
}