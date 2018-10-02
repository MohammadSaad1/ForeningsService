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
    public class AktivitetstypesController : ApiController
    {
        private Model db = new Model();

        // GET: api/Aktivitetstypes
        public IQueryable<Aktivitetstype> GetAktivitetstype()
        {
            return db.Aktivitetstype;
        }

        // GET: api/Aktivitetstypes/5
        [ResponseType(typeof(Aktivitetstype))]
        public async Task<IHttpActionResult> GetAktivitetstype(int id)
        {
            Aktivitetstype aktivitetstype = await db.Aktivitetstype.FindAsync(id);
            if (aktivitetstype == null)
            {
                return NotFound();
            }

            return Ok(aktivitetstype);
        }

        // PUT: api/Aktivitetstypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAktivitetstype(int id, Aktivitetstype aktivitetstype)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aktivitetstype.AktivitetstypeID)
            {
                return BadRequest();
            }

            db.Entry(aktivitetstype).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AktivitetstypeExists(id))
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

        // POST: api/Aktivitetstypes
        [ResponseType(typeof(Aktivitetstype))]
        public async Task<IHttpActionResult> PostAktivitetstype(Aktivitetstype aktivitetstype)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Aktivitetstype.Add(aktivitetstype);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aktivitetstype.AktivitetstypeID }, aktivitetstype);
        }

        // DELETE: api/Aktivitetstypes/5
        [ResponseType(typeof(Aktivitetstype))]
        public async Task<IHttpActionResult> DeleteAktivitetstype(int id)
        {
            Aktivitetstype aktivitetstype = await db.Aktivitetstype.FindAsync(id);
            if (aktivitetstype == null)
            {
                return NotFound();
            }

            db.Aktivitetstype.Remove(aktivitetstype);
            await db.SaveChangesAsync();

            return Ok(aktivitetstype);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AktivitetstypeExists(int id)
        {
            return db.Aktivitetstype.Count(e => e.AktivitetstypeID == id) > 0;
        }
    }
}