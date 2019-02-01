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
    public class PosadaLetaController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        // GET: api/PosadaLeta
        public IQueryable<PosadaLeta> GetPosadaLeta()
        {
            return db.PosadaLeta;
        }

        [HttpGet]
        [Route("api/PosadaLeta/SearchPosadaLeta/{letID}")]
        public IHttpActionResult SearchPosadaLeta(int letID)
        {
            List<PosadaLeta> posadaLeta = db.PosadaLeta.Include(x => x.Zaposlenik).Include(x => x.Zaposlenik.TipZaposlenja).Where(x => x.LetID == letID).ToList();
            if (posadaLeta == null)
            {
                return NotFound();
            }

            foreach (PosadaLeta p in posadaLeta)
            {
                p.Ime = p.Zaposlenik.Ime;
                p.Pozicija = p.Zaposlenik.TipZaposlenja.Naziv;
                p.DatumRodenja = p.Zaposlenik.DatumRodenja.ToShortDateString();
                p.Prezime = p.Zaposlenik.Prezime;
                p.Telefon = p.Zaposlenik.Telefon;
            }
            return Ok(posadaLeta);
        }
        

       

        // PUT: api/PosadaLeta/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPosadaLeta(int id, PosadaLeta posadaLeta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != posadaLeta.PosadaLetaID)
            {
                return BadRequest();
            }

            db.Entry(posadaLeta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PosadaLetaExists(id))
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

        // POST: api/PosadaLeta
        [ResponseType(typeof(PosadaLeta))]
        public IHttpActionResult PostPosadaLeta(PosadaLeta posadaLeta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PosadaLeta.Add(posadaLeta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = posadaLeta.PosadaLetaID }, posadaLeta);
        }

        // DELETE: api/PosadaLeta/5
        public IHttpActionResult DeletePosadaLeta(int id)
        {
            PosadaLeta posadaLeta = db.PosadaLeta.Find(id);
            if (posadaLeta == null)
            {
                return NotFound();
            }

            db.PosadaLeta.Remove(posadaLeta);
            db.SaveChanges();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PosadaLetaExists(int id)
        {
            return db.PosadaLeta.Count(e => e.PosadaLetaID == id) > 0;
        }
    }
}