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
    public class KorisnickiNalogController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        

        [Route("api/KorisnickiNalog/GetNalogUsernamePassword/{username}/{password}/{id}")]
        [ResponseType(typeof(Zaposlenik))]
        public IHttpActionResult GetNalogUsernamePassword(string username,string password, int id)
        {
            KorisnickiNalog korisnickiNalog = db.KorisnickiNalog.Where(x => x.KorisnickoIme == username && x.Lozinka == password && x.Status==true).FirstOrDefault();
            if (korisnickiNalog == null)
            {
                return NotFound();
            }
            Zaposlenik z = db.Zaposlenik.Where(x => x.ZaposlenikID == korisnickiNalog.ZaposlenikID).FirstOrDefault();

            if (!z.Aktivan)
                return NotFound();

            return Ok(z);
        }

        [Route("api/KorisnickiNalog/GetNalogByUsername/{username}/{id}")]
        [ResponseType(typeof(KorisnickiNalog))]
        public IHttpActionResult GetNalogByUsername(string username, int id)//provjera da ne postoji username vec
        {
            KorisnickiNalog korisnickiNalog = db.KorisnickiNalog.Where(x => x.KorisnickoIme == username && x.Status == true).FirstOrDefault();
            if (korisnickiNalog == null)
            {
                return NotFound();
            }
            return Ok();
        }



        [Route("api/KorisnickiNalog/GetNalogByZaposlenikID/{zaposlenikID}")]
        public IHttpActionResult GetNalogByZaposlenikID(int zaposlenikID)
        {
            KorisnickiNalog korisnickiNalog = db.KorisnickiNalog.Where(x => x.ZaposlenikID == zaposlenikID && x.Status == true).FirstOrDefault();
            if (korisnickiNalog == null)
            {
                return NotFound();
            }

            return Ok(korisnickiNalog);
        }
        

        // PUT: api/KorisnickiNalog/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnickiNalog(int id, KorisnickiNalog korisnickiNalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnickiNalog.KorisnickiNalogID)
            {
                return BadRequest();
            }

            KorisnickiNalog k = db.KorisnickiNalog.Find(id);
            k.KorisnickiNalogID = korisnickiNalog.KorisnickiNalogID;
            k.KorisnickoIme = korisnickiNalog.KorisnickoIme;
            k.Lozinka = korisnickiNalog.Lozinka;
            k.Status = korisnickiNalog.Status;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/KorisnickiNalog
        [ResponseType(typeof(KorisnickiNalog))]
        public IHttpActionResult PostKorisnickiNalog(KorisnickiNalog korisnickiNalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KorisnickiNalog.Add(korisnickiNalog);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = korisnickiNalog.KorisnickiNalogID }, korisnickiNalog);
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