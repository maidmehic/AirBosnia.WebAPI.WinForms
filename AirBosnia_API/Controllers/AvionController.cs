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
    public class AvionController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        // GET: api/Avion
        public IHttpActionResult GetAvion()
        {
            return Ok(db.Avion.ToList());
        }

        // GET: api/Avion/5
        [ResponseType(typeof(Avion))]
        public IHttpActionResult GetAvion(int id)
        {
            Avion avion = db.Avion.Find(id);
            if (avion == null)
            {
                return NotFound();
            }

            return Ok(avion);
        }

        [HttpGet]
        [Route("api/Avion/SearchByOznaka/{oznaka?}")]
        [ResponseType(typeof(Avion))]
        public IHttpActionResult SearchByOznaka(string oznaka="")
        {

            if (oznaka=="")
            {
                List<Avion> avion = db.Avion.ToList();

                return Ok(avion);
            }
            else
            {
                List<Avion> avion = db.Avion.Where(x => x.Oznaka.ToLower().StartsWith(oznaka.ToLower())).ToList();
                if (avion.Count == 0)
                {
                    return NotFound();
                }

                return Ok(avion);
            }
          
        }

        // PUT: api/Avion/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAvion(int id, Avion avion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != avion.AvionID)
            {
                return BadRequest();
            }

            Avion a = db.Avion.Find(id);
            a.AvionID = avion.AvionID;
            a.BrojSjedistaBuss = avion.BrojSjedistaBuss;
            a.BrojSjedistaEco = avion.BrojSjedistaEco;
            a.Naziv = avion.Naziv;
            a.Oznaka = avion.Oznaka;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Avion
        [ResponseType(typeof(Avion))]
        public IHttpActionResult PostAvion(Avion avion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Avion.Add(avion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = avion.AvionID }, avion);
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