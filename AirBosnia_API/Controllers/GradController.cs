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
    public class GradController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        // GET: api/Grad
        public IHttpActionResult GetGrad()
        {
            return Ok(db.Grad.ToList());
        }

        [Route("api/Grad/GetPolazisteOdrediste/{parametar}")]
        [ResponseType(typeof(Grad))]
        public IHttpActionResult GetPolazisteOdrediste(string parametar)
        {
            List<Grad> g = db.Grad.Where(x => x.Oznaka!="").ToList();
            if (g == null)
                return NotFound();
            return Ok(g);
        }

        [HttpGet]
        [Route("api/Grad/GetByNaziv/{naziv}")]
        [ResponseType(typeof(Grad))]
        public IHttpActionResult GetByNaziv(string naziv)
        {
            Grad g = db.Grad.Where(x => x.Naziv.ToLower() == naziv.ToLower()).FirstOrDefault();
            if (g == null)
                return NotFound();
            return Ok();
        }

        [HttpGet]
        [Route("api/Grad/GetByNazivEdit/{naziv}/{id}")]
        [ResponseType(typeof(Grad))]
        public IHttpActionResult GetByNazivEdit(string naziv,int id)
        {
            Grad g = db.Grad.Where(x => x.Naziv.ToLower() == naziv.ToLower() && x.GradID!=id).FirstOrDefault();
            if (g == null)
                return NotFound();
            return Ok();
        }

        [HttpGet]
        [Route("api/Grad/GetByOznaka/{oznaka}")]
        [ResponseType(typeof(Grad))]
        public IHttpActionResult GetByOznaka(string oznaka)
        {
            Grad g = db.Grad.Where(x => x.Oznaka.ToLower() == oznaka.ToLower()).FirstOrDefault();
            if (g == null)
                return NotFound();
            return Ok();
        }

        [HttpGet]
        [Route("api/Grad/GetByOznakaEdit/{oznaka}/{id}")]
        [ResponseType(typeof(Grad))]
        public IHttpActionResult GetByOznakaEdit(string oznaka, int id)
        {
            Grad g = db.Grad.Where(x => x.Oznaka.ToLower() == oznaka.ToLower() && x.GradID!=id).FirstOrDefault();
            if (g == null)
                return NotFound();
            return Ok();
        }


        [HttpGet]
        [Route("api/Grad/SearchByNaziv/{naziv?}")]
        [ResponseType(typeof(Grad))]
        public IHttpActionResult SearchByNaziv(string naziv = "")
        {

            if (naziv == "")
            {
                List<Grad> lokacije = db.Grad.ToList();

                return Ok(lokacije);
            }
            else
            {
                List<Grad> lokacije = db.Grad.Where(x => x.Naziv.ToLower().StartsWith(naziv.ToLower())).ToList();
                if (lokacije.Count == 0)
                {
                    return NotFound();
                }

                return Ok(lokacije);
            }

        }

        // GET: api/Grad/5
        [ResponseType(typeof(Grad))]
        public IHttpActionResult GetGrad(int id)
        {
            Grad grad = db.Grad.Find(id);
            if (grad == null)
            {
                return NotFound();
            }

            return Ok(grad);
        }

        // PUT: api/Grad/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGrad(int id, Grad grad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != grad.GradID)
            {
                return BadRequest();
            }

            Grad g = db.Grad.Find(id);
            g.Naziv = grad.Naziv;
            g.Oznaka = grad.Oznaka;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Grad
        [ResponseType(typeof(Grad))]
        public IHttpActionResult PostGrad(Grad grad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Grad.Add(grad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = grad.GradID }, grad);
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