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
using AirBosnia_API.ViewModels;

namespace AirBosnia_API.Controllers
{
    public class SjedisteController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        // GET: api/Sjediste
        public IQueryable<Sjediste> GetSjediste()
        {
            return db.Sjediste;
        }

        [HttpGet]
        [Route("api/Sjediste/SearchSlobodnaSjedista/{letId}/{odabranaKlasa}")]
        public IHttpActionResult SearchSlobodnaSjedista(int letId,int odabranaKlasa)
        {
            if (odabranaKlasa == 0)
            {
                Sjedista_IndexVM Model = new Sjedista_IndexVM();
                Model.sjedista = db.Sjediste.Where(x => x.LetID == letId && x.isZauzeto == false && x.isBussiness==false).
                    Select(x => new Sjedista_IndexVM.Rows
                    {
                        SjedisteID = x.SjedisteID,
                        LetID = x.LetID,
                        Oznaka = x.Oznaka,
                        isProzor = x.isProzor
                    }).ToList();

                return Ok(Model);
            }
            else
            {
                Sjedista_IndexVM Model = new Sjedista_IndexVM();
                Model.sjedista = db.Sjediste.Where(x => x.LetID == letId && x.isZauzeto == false && x.isBussiness == true).
                    Select(x => new Sjedista_IndexVM.Rows
                    {
                        SjedisteID = x.SjedisteID,
                        LetID = x.LetID,
                        Oznaka = x.Oznaka,
                        isProzor = x.isProzor
                    }).ToList();

                return Ok(Model);
            }
            
        }

        [HttpGet]
        [Route("api/Sjediste/CountSjedista/{id}")]
        public IHttpActionResult CountSjedista(int id)
        {
            CountSjedistaVM Model = new CountSjedistaVM();
            Model.brSlBuss = db.Sjediste.Where(x => x.LetID == id && x.isBussiness == true && x.isZauzeto == false).Count();
            Model.brZaBuss = db.Sjediste.Where(x => x.LetID == id && x.isBussiness == true && x.isZauzeto == true).Count();
            Model.brSlEco = db.Sjediste.Where(x => x.LetID == id && x.isBussiness == false && x.isZauzeto == false).Count();
            Model.brZaEco = db.Sjediste.Where(x => x.LetID == id && x.isBussiness == false && x.isZauzeto == true).Count();

            return Ok(Model);
        }

        // GET: api/Sjediste/5
        [ResponseType(typeof(Sjediste))]
        public IHttpActionResult GetSjediste(int id)
        {
            Sjediste sjediste = db.Sjediste.Find(id);
            if (sjediste == null)
            {
                return NotFound();
            }

            return Ok(sjediste);
        }

        // PUT: api/Sjediste/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSjediste(int id, Sjediste sjediste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sjediste.SjedisteID)
            {
                return BadRequest();
            }

            Sjediste s = db.Sjediste.Find(id);
            s.isBussiness = sjediste.isBussiness;
            s.isProzor = sjediste.isProzor;
            s.isZauzeto = sjediste.isZauzeto;
            s.LetID = sjediste.LetID;
            s.Oznaka = sjediste.Oznaka;
            s.SjedisteID = sjediste.SjedisteID;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Sjediste
        [ResponseType(typeof(Sjediste))]
        public IHttpActionResult PostSjediste(Sjediste sjediste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sjediste.Add(sjediste);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sjediste.SjedisteID }, sjediste);
        }

        // DELETE: api/Sjediste/5
        [ResponseType(typeof(Sjediste))]
        public IHttpActionResult DeleteSjediste(int id)
        {
            Sjediste sjediste = db.Sjediste.Find(id);
            if (sjediste == null)
            {
                return NotFound();
            }

            db.Sjediste.Remove(sjediste);
            db.SaveChanges();

            return Ok(sjediste);
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