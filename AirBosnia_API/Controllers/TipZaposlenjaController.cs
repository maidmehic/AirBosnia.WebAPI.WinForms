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
using AirBosnia_API.Models;

namespace AirBosnia_API.Controllers
{
    public class TipZaposlenjaController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        // GET: api/TipZaposlenja
        public IHttpActionResult GetTipZaposlenja()
        {
            return Ok(db.TipZaposlenja.ToList());
        }

        // GET: api/TipZaposlenja/5
        [ResponseType(typeof(TipZaposlenja))]
        public IHttpActionResult GetTipZaposlenja(int id)
        {
            TipZaposlenja tipZaposlenja = db.TipZaposlenja.Find(id);
            if (tipZaposlenja == null)
            {
                return NotFound();
            }

            return Ok(tipZaposlenja);
        }

        // PUT: api/TipZaposlenja/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipZaposlenja(int id, TipZaposlenja tipZaposlenja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipZaposlenja.TipZaposlenjaID)
            {
                return BadRequest();
            }

            db.Entry(tipZaposlenja).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipZaposlenjaExists(id))
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

        // POST: api/TipZaposlenja
        [ResponseType(typeof(TipZaposlenja))]
        public IHttpActionResult PostTipZaposlenja(TipZaposlenja tipZaposlenja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipZaposlenja.Add(tipZaposlenja);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipZaposlenja.TipZaposlenjaID }, tipZaposlenja);
        }

        // DELETE: api/TipZaposlenja/5
        [ResponseType(typeof(TipZaposlenja))]
        public IHttpActionResult DeleteTipZaposlenja(int id)
        {
            TipZaposlenja tipZaposlenja = db.TipZaposlenja.Find(id);
            if (tipZaposlenja == null)
            {
                return NotFound();
            }

            db.TipZaposlenja.Remove(tipZaposlenja);
            db.SaveChanges();

            return Ok(tipZaposlenja);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipZaposlenjaExists(int id)
        {
            return db.TipZaposlenja.Count(e => e.TipZaposlenjaID == id) > 0;
        }
    }
}