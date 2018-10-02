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
    public class UnderaktivitetsController : ApiController
    {
        private Model db = new Model();

        // GET: api/Underaktivitets
        public IQueryable<Underaktivitet> GetUnderaktivitet()
        {
            return db.Underaktivitet;
        }

        // GET: api/Underaktivitets/5
        [ResponseType(typeof(Underaktivitet))]
        public async Task<IHttpActionResult> GetUnderaktivitet(int id)
        {
            Underaktivitet underaktivitet = await db.Underaktivitet.FindAsync(id);
            if (underaktivitet == null)
            {
                return NotFound();
            }

            return Ok(underaktivitet);
        }

        // PUT: api/Underaktivitets/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUnderaktivitet(int id, Underaktivitet underaktivitet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != underaktivitet.UnderaktivitetID)
            {
                return BadRequest();
            }

            db.Entry(underaktivitet).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnderaktivitetExists(id))
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

        // POST: api/Underaktivitets
        [ResponseType(typeof(Underaktivitet))]
        public async Task<IHttpActionResult> PostUnderaktivitet(Underaktivitet underaktivitet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Underaktivitet.Add(underaktivitet);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = underaktivitet.UnderaktivitetID }, underaktivitet);
        }

        // DELETE: api/Underaktivitets/5
        [ResponseType(typeof(Underaktivitet))]
        public async Task<IHttpActionResult> DeleteUnderaktivitet(int id)
        {
            Underaktivitet underaktivitet = await db.Underaktivitet.FindAsync(id);
            if (underaktivitet == null)
            {
                return NotFound();
            }

            db.Underaktivitet.Remove(underaktivitet);
            await db.SaveChangesAsync();

            return Ok(underaktivitet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UnderaktivitetExists(int id)
        {
            return db.Underaktivitet.Count(e => e.UnderaktivitetID == id) > 0;
        }
    }
}