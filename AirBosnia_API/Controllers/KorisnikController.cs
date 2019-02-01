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
    public class KorisnikController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        // GET: api/Korisnik
        public IHttpActionResult GetKorisnik()
        {
            return Ok(db.Korisnik.ToList());
        }

        [Route("api/Korisnik/SearchKorisnikByPrijava/{email}/{lozinka}/{parametar}")]
        [ResponseType(typeof(Korisnik))]
        [HttpGet]
        public IHttpActionResult SearchKorisnikByPrijava(string email,string lozinka,string parametar)
        {
            Korisnik k = db.Korisnik.Where(x=>x.Email==email && x.Lozinka==lozinka).FirstOrDefault();
            if (k == null)
                return NotFound();
            return Ok(k);
        }

        [HttpGet]
        [Route("api/Korisnik/SearchByEmail/{email}/{id}")]
        public IHttpActionResult SearchByEmail(string email, int id)
        {
            Korisnik k = db.Korisnik.Where(x => x.Email == email && x.KorisnikID!=id).FirstOrDefault();
            if (k == null)
            {
                return NotFound();
            }

            return Ok();
        }


        // GET: api/Korisnik/5
        [ResponseType(typeof(Korisnik))]
        public IHttpActionResult GetKorisnik(int id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik);
        }

        // PUT: api/Korisnik/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnik(int id, Korisnik korisnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnik.KorisnikID)
            {
                return BadRequest();
            }

            Korisnik k = db.Korisnik.Find(id);
            k.KorisnikID = korisnik.KorisnikID;
            k.Email = korisnik.Email;
            k.Ime = korisnik.Ime;
            k.Lozinka = korisnik.Lozinka;
            k.Prezime = korisnik.Prezime;

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Korisnik
        [ResponseType(typeof(Korisnik))]
        public IHttpActionResult PostKorisnik(Korisnik korisnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Korisnik.Add(korisnik);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = korisnik.KorisnikID }, korisnik);
        }

        // DELETE: api/Korisnik/5
        [ResponseType(typeof(Korisnik))]
        public IHttpActionResult DeleteKorisnik(int id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return NotFound();
            }

            db.Korisnik.Remove(korisnik);
            db.SaveChanges();

            return Ok(korisnik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}