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
    public class PosebnaPonudaController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();

        // GET: api/PosebnaPonuda
        public IHttpActionResult GetPosebnaPonuda()
        {
            PosebnPonuda_IndexVM Model = new PosebnPonuda_IndexVM();
            Model.ponude = db.PosebnaPonuda.Include(x => x.Let1).
                Include(x => x.Let1.Grad1).//polaziste
                Include(x => x.Let1.Grad).//odrediste
                Include(x => x.Zaposlenik).
                Where(x => x.Let1.DatumVrijemeDolaska >= DateTime.Now).
                Select(x => new PosebnPonuda_IndexVM.Rows
                {
                    PosebnaPonudaID = x.PosebnaPonudaID,
                    DatumVrijemePolaska = x.Let1.DatumVrijemePolaska.ToString(),
                    Polaziste = x.Let1.Grad1.Naziv + " " + x.Let1.Grad1.Oznaka,
                    Odrediste = x.Let1.Grad.Naziv + " " + x.Let1.Grad.Oznaka,
                    BrojLeta = x.Let1.BrojLeta,
                    CijenaBezKarte = x.CijenaBezKarte.ToString(),
                    Smjestaj = x.Smjestaj,
                    Napomena = x.Napomena,
                    Evidentirao = x.Zaposlenik.Ime + " " + x.Zaposlenik.Prezime,
                    BrojDana = x.BrojDana
                }).ToList();
            return Ok(Model);
        }

        [HttpGet]
        [Route("api/PosebnaPonuda/SearchAktivnePonude/{parametar}")]
        public IHttpActionResult SearchAktivnePonude(int parametar)//mobilni dio
        {
            List<PosebnaPonuda> ponude = db.PosebnaPonuda.Include(x => x.Let1).Include(x => x.Let).
                 Include(x => x.Let1.Grad1).//polaziste
                 Include(x => x.Let1.Grad).//odrediste
                 Where(x => x.Let1.DatumVrijemePolaska > DateTime.Now).ToList();

            PretragaPosebnigPonudaVM Model = new PretragaPosebnigPonudaVM();
            Model.podaci = ponude.Select(x => new PretragaPosebnigPonudaVM.Rows
            {
                PonudaID = x.PosebnaPonudaID,
                Polazak = x.Let1.Grad1.Naziv,
                Destinacija = x.Let1.Grad.Naziv,
                Smjestaj = x.Smjestaj,
                Napomena = x.Napomena,
                DatumPovratka=x.Let.DatumVrijemePolaska.ToString("d MMM yyyy"),
                DatumPolaska = x.Let1.DatumVrijemePolaska.ToString("d MMM yyyy HH:mm") + ", " + x.BrojDana + " dana",
                DatumDaniNocenja = x.Let1.DatumVrijemePolaska.ToString("d MMM yyyy") + ", " + x.BrojDana + " dana",
                Cijena = x.CijenaBezKarte + x.Let.CijenaEcoOdrasli + x.Let1.CijenaEcoOdrasli,
                CijenaDjeca= x.CijenaBezKarte + x.Let.CijenaEcoDjeca + x.Let1.CijenaEcoDjeca,
                LetPolazakID=x.LetPolazakID,
                LetDolazakID=x.LetDolazakID
            }).ToList();
            return Ok(Model);
        }

        [HttpGet]
        [Route("api/PosebnaPonuda/SearchPonude/{index?}")]
        public IHttpActionResult SearchPonude(string index = "")
        {
            PosebnPonuda_IndexVM Model = new PosebnPonuda_IndexVM();
            if (index == "0")
            {
                Model.ponude = db.PosebnaPonuda.Include(x => x.Let1).
               Include(x => x.Let1.Grad1).//polaziste
               Include(x => x.Let1.Grad).//odrediste
               Include(x => x.Zaposlenik).
               Where(x => x.Let1.DatumVrijemeDolaska >= DateTime.Now).
               Select(x => new PosebnPonuda_IndexVM.Rows
               {
                   PosebnaPonudaID = x.PosebnaPonudaID,
                   DatumVrijemePolaska = x.Let1.DatumVrijemePolaska.ToString(),
                   Polaziste = x.Let1.Grad1.Naziv + " " + x.Let1.Grad1.Oznaka,
                   Odrediste = x.Let1.Grad.Naziv + " " + x.Let1.Grad.Oznaka,
                   BrojLeta = x.Let1.BrojLeta,
                   CijenaBezKarte = x.CijenaBezKarte.ToString(),
                   Smjestaj = x.Smjestaj,
                   Napomena = x.Napomena,
                   Evidentirao = x.Zaposlenik.Ime + " " + x.Zaposlenik.Prezime,
                   BrojDana = x.BrojDana
               }).ToList();

                return Ok(Model);

            }
            else if (index == "1")
            {
                Model.ponude = db.PosebnaPonuda.Include(x => x.Let1).
               Include(x => x.Let1.Grad1).//polaziste
               Include(x => x.Let1.Grad).//odrediste
               Include(x => x.Zaposlenik).
               Where(x => x.Let1.DatumVrijemeDolaska < DateTime.Now).
               Select(x => new PosebnPonuda_IndexVM.Rows
               {
                   PosebnaPonudaID = x.PosebnaPonudaID,
                   DatumVrijemePolaska = x.Let1.DatumVrijemePolaska.ToString(),
                   Polaziste = x.Let1.Grad1.Naziv + " " + x.Let1.Grad1.Oznaka,
                   Odrediste = x.Let1.Grad.Naziv + " " + x.Let1.Grad.Oznaka,
                   BrojLeta = x.Let1.BrojLeta,
                   CijenaBezKarte = x.CijenaBezKarte.ToString(),
                   Smjestaj = x.Smjestaj,
                   Napomena = x.Napomena,
                   Evidentirao = x.Zaposlenik.Ime + " " + x.Zaposlenik.Prezime,
                   BrojDana = x.BrojDana
               }).ToList();

                return Ok(Model);

            }
            else
            {
                Model.ponude = db.PosebnaPonuda.Include(x => x.Let1).
               Include(x => x.Let1.Grad1).//polaziste
               Include(x => x.Let1.Grad).//odrediste
               Include(x => x.Zaposlenik).
               Select(x => new PosebnPonuda_IndexVM.Rows
               {
                   PosebnaPonudaID = x.PosebnaPonudaID,
                   DatumVrijemePolaska = x.Let1.DatumVrijemePolaska.ToString(),
                   Polaziste = x.Let1.Grad1.Naziv + " " + x.Let1.Grad1.Oznaka,
                   Odrediste = x.Let1.Grad.Naziv + " " + x.Let1.Grad.Oznaka,
                   BrojLeta = x.Let1.BrojLeta,
                   CijenaBezKarte = x.CijenaBezKarte.ToString(),
                   Smjestaj = x.Smjestaj,
                   Napomena = x.Napomena,
                   Evidentirao = x.Zaposlenik.Ime + " " + x.Zaposlenik.Prezime,
                   BrojDana = x.BrojDana
               }).ToList();

                return Ok(Model);

            }
        }



        // GET: api/PosebnaPonuda/5
        [ResponseType(typeof(PosebnaPonuda))]
        public IHttpActionResult GetPosebnaPonuda(int id)
        {
            PosebnaPonuda posebnaPonuda = db.PosebnaPonuda.
                Include(x=>x.Let1).
                Include(x=>x.Let1.Grad1).
                Include(x=>x.Let1.Grad).
                Include(x => x.Let).
                Include(x => x.Let.Grad1).
                Include(x => x.Let.Grad).
                Include(x => x.Zaposlenik).
            Where(x => x.PosebnaPonudaID == id).FirstOrDefault();


            if (posebnaPonuda == null)
            {
                return NotFound();
            }

            return Ok(posebnaPonuda);
        }

        // PUT: api/PosebnaPonuda/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPosebnaPonuda(int id, PosebnaPonuda posebnaPonuda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != posebnaPonuda.PosebnaPonudaID)
            {
                return BadRequest();
            }

            PosebnaPonuda p = db.PosebnaPonuda.Find(id);
            p.PosebnaPonudaID = posebnaPonuda.PosebnaPonudaID;
            p.LetPolazakID= posebnaPonuda.LetPolazakID;
            p.LetDolazakID= posebnaPonuda.LetDolazakID;
            p.ZaposlenikID= posebnaPonuda.ZaposlenikID;
            p.CijenaBezKarte= posebnaPonuda.CijenaBezKarte;
            p.BrojDana= posebnaPonuda.BrojDana;
            p.Smjestaj= posebnaPonuda.Smjestaj;
            p.Napomena= posebnaPonuda.Napomena;

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PosebnaPonuda
        [ResponseType(typeof(PosebnaPonuda))]
        public IHttpActionResult PostPosebnaPonuda(PosebnaPonuda posebnaPonuda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PosebnaPonuda.Add(posebnaPonuda);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = posebnaPonuda.PosebnaPonudaID }, posebnaPonuda);
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