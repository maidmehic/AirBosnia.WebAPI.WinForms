using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AirBosnia_API.Models;
using AirBosnia_API.ViewModels;

namespace AirBosnia_API.Controllers
{
    public class LetController : ApiController
    {
        private AirBosniaEntities db = new AirBosniaEntities();


        [HttpGet]
        [Route("api/Let/SearchLetByPolazisteOdrediste/{datum}/{polazisteID}/{odredisteID}")]
        public IHttpActionResult SearchLetByPolazisteOdrediste(string datum, int polazisteID, int odredisteID)
        {
            Letovi_RezervacijaVM temp = new Letovi_RezervacijaVM();
            DateTime Datum = DateTime.Parse(datum);

            List<Let> letovi = db.Let.Include(x => x.Grad).Include(x => x.Grad1).
                Where(x=>x.isPosebnaPonuda==false&& x.PolazisteID==polazisteID && x.OdredisteID==odredisteID &&
                DbFunctions.TruncateTime(x.DatumVrijemePolaska) ==Datum.Date && x.StatusLeta == false).
                ToList();

            temp.podaci = letovi.Select(x => new Letovi_RezervacijaVM.Rows
                    {
                        LetID = x.LetID,
                        PolazisteID = x.PolazisteID,
                        OdredisteID = x.OdredisteID,
                        BrojLeta = x.BrojLeta,

                        DatumPolaska = x.DatumVrijemePolaska.ToString("d MMM, yyyy"),
                        DatumDolaska = x.DatumVrijemeDolaska.ToString("d MMM, yyyy"),

                        VrijemePolaska = x.DatumVrijemePolaska.ToString("HH:mm"),
                        VrijemeDolaska = x.DatumVrijemeDolaska.ToString("HH:mm"),

                        CijenaBussOdrasli = x.CijenaBussOdrasli,
                        CijenaBussDjeca = x.CijenaBussDjeca,
                        CijenaEcoDjeca = x.CijenaEcoDjeca,
                        CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                        polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                        odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                        BrojSlobodnihBussiness=Convert.ToInt32(db.Sjediste.Where(p=>p.LetID==x.LetID && p.isBussiness==true && p.isZauzeto==false).Count()),
                        BrojSlobodnihEkonomska=Convert.ToInt32(db.Sjediste.Where(p=>p.LetID==x.LetID && p.isBussiness==false && p.isZauzeto==false).Count())
                    }).ToList();

            Letovi_RezervacijaVM Model = new Letovi_RezervacijaVM();
            Model.podaci = new List<Letovi_RezervacijaVM.Rows>();
            Model.podaci = temp.podaci.Where(x => x.BrojSlobodnihBussiness > 0 || x.BrojSlobodnihEkonomska > 0).ToList();

            return Ok(Model);
        }



        [HttpGet]
        [Route("api/Let/SearchLetovi/{index?}/{broj?}")]
        public IHttpActionResult SearchLetovi(string index="", string broj = "")
        {
            Letovi_IndexVM Model = new Letovi_IndexVM();
            if (broj == "")
            {
                if (index == "0")
                {
                    Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                    Where(x => x.DatumVrijemeDolaska >= DateTime.Now && x.StatusLeta==false).
                    Select(x => new Letovi_IndexVM.Rows
                    {
                        LetID = x.LetID,
                        PolazisteID = x.PolazisteID,
                        OdredisteID = x.OdredisteID,
                        ZaposlenikID = x.ZaposlenikID,
                        BrojLeta = x.BrojLeta,
                        AvionID = x.AvionID,
                        DatumVrijemePolaska = x.DatumVrijemePolaska,
                        DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                        StatusLeta = x.StatusLeta,
                        CijenaBussOdrasli = x.CijenaBussOdrasli,
                        CijenaBussDjeca = x.CijenaBussDjeca,
                        CijenaEcoDjeca = x.CijenaEcoDjeca,
                        CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                        polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                        odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                        avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                    }).ToList();
                    return Ok(Model);

                }
                else if (index == "1")
                {
                    Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                                   Where(x => x.DatumVrijemeDolaska < DateTime.Now && x.StatusLeta == false).
                                   Select(x => new Letovi_IndexVM.Rows
                                   {
                                       LetID = x.LetID,
                                       PolazisteID = x.PolazisteID,
                                       OdredisteID = x.OdredisteID,
                                       ZaposlenikID = x.ZaposlenikID,
                                       BrojLeta = x.BrojLeta,
                                       AvionID = x.AvionID,
                                       DatumVrijemePolaska = x.DatumVrijemePolaska,
                                       DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                                       StatusLeta = x.StatusLeta,
                                       CijenaBussOdrasli = x.CijenaBussOdrasli,
                                       CijenaBussDjeca = x.CijenaBussDjeca,
                                       CijenaEcoDjeca = x.CijenaEcoDjeca,
                                       CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                                       polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                                       odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                                       avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                                   }).ToList();
                    return Ok(Model);
                }
                else if(index == "2")
                {
                    Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                                  Select(x => new Letovi_IndexVM.Rows
                                  {
                                      LetID = x.LetID,
                                      PolazisteID = x.PolazisteID,
                                      OdredisteID = x.OdredisteID,
                                      ZaposlenikID = x.ZaposlenikID,
                                      BrojLeta = x.BrojLeta,
                                      AvionID = x.AvionID,
                                      DatumVrijemePolaska = x.DatumVrijemePolaska,
                                      DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                                      StatusLeta = x.StatusLeta,
                                      CijenaBussOdrasli = x.CijenaBussOdrasli,
                                      CijenaBussDjeca = x.CijenaBussDjeca,
                                      CijenaEcoDjeca = x.CijenaEcoDjeca,
                                      CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                                      polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                                      odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                                      avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                                  }).ToList();
                    return Ok(Model);
                }
                else
                {
                    Model.podaci = db.Let.Include(x => x.Grad).Where(x=>x.StatusLeta==true)
                        .OrderByDescending(x=>x.LetID).Include(x => x.Grad1).Include(x => x.Avion).
                                  Select(x => new Letovi_IndexVM.Rows
                                  {
                                      LetID = x.LetID,
                                      PolazisteID = x.PolazisteID,
                                      OdredisteID = x.OdredisteID,
                                      ZaposlenikID = x.ZaposlenikID,
                                      BrojLeta = x.BrojLeta,
                                      AvionID = x.AvionID,
                                      DatumVrijemePolaska = x.DatumVrijemePolaska,
                                      DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                                      StatusLeta = x.StatusLeta,
                                      CijenaBussOdrasli = x.CijenaBussOdrasli,
                                      CijenaBussDjeca = x.CijenaBussDjeca,
                                      CijenaEcoDjeca = x.CijenaEcoDjeca,
                                      CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                                      polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                                      odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                                      avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                                  }).ToList();
                    return Ok(Model);
                }
            }
            else
            {
                if (index == "0")
                {
                    Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                    Where(x => x.StatusLeta == false && x.DatumVrijemeDolaska >= DateTime.Now && x.BrojLeta.ToLower().StartsWith(broj.ToLower())).
                    Select(x => new Letovi_IndexVM.Rows
                    {
                        LetID = x.LetID,
                        PolazisteID = x.PolazisteID,
                        OdredisteID = x.OdredisteID,
                        ZaposlenikID = x.ZaposlenikID,
                        BrojLeta = x.BrojLeta,
                        AvionID = x.AvionID,
                        DatumVrijemePolaska = x.DatumVrijemePolaska,
                        DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                        StatusLeta = x.StatusLeta,
                        CijenaBussOdrasli = x.CijenaBussOdrasli,
                        CijenaBussDjeca = x.CijenaBussDjeca,
                        CijenaEcoDjeca = x.CijenaEcoDjeca,
                        CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                        polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                        odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                        avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                    }).ToList();
                    return Ok(Model);

                }
                else if (index == "1")
                {
                    Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                                   Where(x =>  x.StatusLeta == false && x.DatumVrijemeDolaska < DateTime.Now && x.BrojLeta.ToLower().StartsWith(broj.ToLower())).
                                   Select(x => new Letovi_IndexVM.Rows
                                   {
                                       LetID = x.LetID,
                                       PolazisteID = x.PolazisteID,
                                       OdredisteID = x.OdredisteID,
                                       ZaposlenikID = x.ZaposlenikID,
                                       BrojLeta = x.BrojLeta,
                                       AvionID = x.AvionID,
                                       DatumVrijemePolaska = x.DatumVrijemePolaska,
                                       DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                                       StatusLeta = x.StatusLeta,
                                       CijenaBussOdrasli = x.CijenaBussOdrasli,
                                       CijenaBussDjeca = x.CijenaBussDjeca,
                                       CijenaEcoDjeca = x.CijenaEcoDjeca,
                                       CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                                       polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                                       odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                                       avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                                   }).ToList();
                    return Ok(Model);
                }
                else if(index == "2")
                {
                    Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                        Where(x=>x.BrojLeta.ToLower().StartsWith(broj.ToLower())).
                                  Select(x => new Letovi_IndexVM.Rows
                                  {
                                      LetID = x.LetID,
                                      PolazisteID = x.PolazisteID,
                                      OdredisteID = x.OdredisteID,
                                      ZaposlenikID = x.ZaposlenikID,
                                      BrojLeta = x.BrojLeta,
                                      AvionID = x.AvionID,
                                      DatumVrijemePolaska = x.DatumVrijemePolaska,
                                      DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                                      StatusLeta = x.StatusLeta,
                                      CijenaBussOdrasli = x.CijenaBussOdrasli,
                                      CijenaBussDjeca = x.CijenaBussDjeca,
                                      CijenaEcoDjeca = x.CijenaEcoDjeca,
                                      CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                                      polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                                      odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                                      avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                                  }).ToList();
                    return Ok(Model);
                }
                else
                {
                    Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                                           Where(x =>x.StatusLeta==true && x.BrojLeta.ToLower().StartsWith(broj.ToLower())).
                                           OrderByDescending(x=>x.LetID).
                                                     Select(x => new Letovi_IndexVM.Rows
                                                     {
                                                         LetID = x.LetID,
                                                         PolazisteID = x.PolazisteID,
                                                         OdredisteID = x.OdredisteID,
                                                         ZaposlenikID = x.ZaposlenikID,
                                                         BrojLeta = x.BrojLeta,
                                                         AvionID = x.AvionID,
                                                         DatumVrijemePolaska = x.DatumVrijemePolaska,
                                                         DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                                                         StatusLeta = x.StatusLeta,
                                                         CijenaBussOdrasli = x.CijenaBussOdrasli,
                                                         CijenaBussDjeca = x.CijenaBussDjeca,
                                                         CijenaEcoDjeca = x.CijenaEcoDjeca,
                                                         CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                                                         polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                                                         odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                                                         avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                                                     }).ToList();
                    return Ok(Model);
                }
            }
            
           
        }

        public IHttpActionResult GetLet()
        {
            Letovi_IndexVM Model = new Letovi_IndexVM();
            Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                Where(x=> x.StatusLeta == false && x.DatumVrijemeDolaska>=DateTime.Now).
                Select(x => new Letovi_IndexVM.Rows
                {
                    LetID = x.LetID,
                    PolazisteID = x.PolazisteID,
                    OdredisteID = x.OdredisteID,
                    ZaposlenikID = x.ZaposlenikID,
                    BrojLeta = x.BrojLeta,
                    AvionID = x.AvionID,
                    DatumVrijemePolaska = x.DatumVrijemePolaska,
                    DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                    StatusLeta = x.StatusLeta,
                    CijenaBussOdrasli = x.CijenaBussOdrasli,
                    CijenaBussDjeca = x.CijenaBussDjeca,
                    CijenaEcoDjeca = x.CijenaEcoDjeca,
                    CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                    polaziste=x.Grad1.Naziv+" "+x.Grad1.Oznaka,
                    odrediste=x.Grad.Naziv+" "+x.Grad.Oznaka,
                    avion=x.Avion.Naziv+" "+x.Avion.Oznaka,
                }).ToList();

            return Ok(Model);
        }

        [HttpGet]
        [Route("api/Let/SearchLetPosPonuda/{brojLeta?}")]
        public IHttpActionResult SearchLetPosPonuda(string brojLeta="")
        {
            if (brojLeta == "")
            {
                Letovi_IndexVM Model = new Letovi_IndexVM();
                Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                    Where(x =>x.isPosebnaPonuda==true && x.StatusLeta == false && x.DatumVrijemeDolaska >= DateTime.Now).
                    Select(x => new Letovi_IndexVM.Rows
                    {
                        LetID = x.LetID,
                        PolazisteID = x.PolazisteID,
                        OdredisteID = x.OdredisteID,
                        ZaposlenikID = x.ZaposlenikID,
                        BrojLeta = x.BrojLeta,
                        AvionID = x.AvionID,
                        DatumVrijemePolaska = x.DatumVrijemePolaska,
                        DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                        StatusLeta = x.StatusLeta,
                        CijenaBussOdrasli = x.CijenaBussOdrasli,
                        CijenaBussDjeca = x.CijenaBussDjeca,
                        CijenaEcoDjeca = x.CijenaEcoDjeca,
                        CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                        polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                        odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                        avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                    }).ToList();

                return Ok(Model);
            }
            else
            {
                Letovi_IndexVM Model = new Letovi_IndexVM();
                Model.podaci = db.Let.Include(x => x.Grad).Include(x => x.Grad1).Include(x => x.Avion).
                    Where(x => x.isPosebnaPonuda == true && x.StatusLeta == false && x.DatumVrijemeDolaska >= DateTime.Now && x.BrojLeta==brojLeta).
                    Select(x => new Letovi_IndexVM.Rows
                    {
                        LetID = x.LetID,
                        PolazisteID = x.PolazisteID,
                        OdredisteID = x.OdredisteID,
                        ZaposlenikID = x.ZaposlenikID,
                        BrojLeta = x.BrojLeta,
                        AvionID = x.AvionID,
                        DatumVrijemePolaska = x.DatumVrijemePolaska,
                        DatumVrijemeDolaska = x.DatumVrijemeDolaska,
                        StatusLeta = x.StatusLeta,
                        CijenaBussOdrasli = x.CijenaBussOdrasli,
                        CijenaBussDjeca = x.CijenaBussDjeca,
                        CijenaEcoDjeca = x.CijenaEcoDjeca,
                        CijenaEcoOdrasli = x.CijenaEcoOdrasli,
                        polaziste = x.Grad1.Naziv + " " + x.Grad1.Oznaka,
                        odrediste = x.Grad.Naziv + " " + x.Grad.Oznaka,
                        avion = x.Avion.Naziv + " " + x.Avion.Oznaka,
                    }).ToList();

                return Ok(Model);
            }
            
        }

        // GET: api/Let/5
        [ResponseType(typeof(Let))]
        public IHttpActionResult GetLet(int id)
        {
            Let let = db.Let.Include(x=>x.Grad)
                .Include(x => x.Grad1)
                .Include(x => x.Avion)
                .Include(x => x.Zaposlenik)
                .Where(x=>x.LetID==id).FirstOrDefault();

            if (let == null)
            {
                return NotFound();
            }



            return Ok(let);
        }

        // PUT: api/Let/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLet(int id, Let let)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != let.LetID)
            {
                return BadRequest();
            }

            Let l = db.Let.Find(id);
            int avionID = l.AvionID;

            l.LetID = let.LetID;
            l.PolazisteID = let.PolazisteID;
            l.OdredisteID = let.OdredisteID;
            l.ZaposlenikID= let.ZaposlenikID;
            l.BrojLeta= let.BrojLeta;
            l.AvionID= let.AvionID;
            l.isPosebnaPonuda = let.isPosebnaPonuda;
            l.DatumVrijemePolaska= let.DatumVrijemePolaska;
            l.DatumVrijemeDolaska= let.DatumVrijemeDolaska;
            l.StatusLeta= let.StatusLeta;
            l.CijenaBussDjeca= let.CijenaBussDjeca;
            l.CijenaBussOdrasli= let.CijenaBussOdrasli;
            l.CijenaEcoDjeca= let.CijenaEcoDjeca;
            l.CijenaEcoOdrasli= let.CijenaEcoOdrasli;

            db.SaveChanges();

            if (avionID != l.AvionID)
            {
                foreach (Sjediste sjediste in db.Sjediste.Where(x=>x.LetID==l.LetID).ToList())
                {
                    db.Sjediste.Remove(sjediste);
                }
                db.SaveChanges();

                Avion avion = db.Avion.Find(let.AvionID);
                for (int i = 0; i < avion.BrojSjedistaBuss / 2; i++)
                {
                    Sjediste s1 = new Sjediste();
                    s1.isBussiness = true;
                    s1.isProzor = true;
                    s1.isZauzeto = false;
                    s1.LetID = let.LetID;
                    s1.Oznaka = "A" + (i + 1);

                    db.Sjediste.Add(s1);

                    Sjediste s2 = new Sjediste();
                    s2.isBussiness = true;
                    s2.isProzor = true;
                    s2.isZauzeto = false;
                    s2.LetID = let.LetID;
                    s2.Oznaka = "B" + (i + 1);

                    db.Sjediste.Add(s2);

                }


                for (int i = 0; i < avion.BrojSjedistaEco / 6; i++)
                {
                    Sjediste s1 = new Sjediste();
                    s1.isBussiness = false;
                    s1.isProzor = false;
                    s1.isZauzeto = false;
                    s1.LetID = let.LetID;
                    s1.Oznaka = "A" + (i + 1).ToString();
                    db.Sjediste.Add(s1);

                    Sjediste s2 = new Sjediste();
                    s2.isBussiness = false;
                    s2.isProzor = false;
                    s2.isZauzeto = false;
                    s2.LetID = let.LetID;
                    s2.Oznaka = "B" + (i + 1).ToString();
                    db.Sjediste.Add(s2);

                    Sjediste s3 = new Sjediste();
                    s3.isBussiness = false;
                    s3.isProzor = true;
                    s3.isZauzeto = false;
                    s3.LetID = let.LetID;
                    s3.Oznaka = "C" + (i + 1).ToString();
                    db.Sjediste.Add(s3);

                    Sjediste s4 = new Sjediste();
                    s4.isBussiness = false;
                    s4.isProzor = false;
                    s4.isZauzeto = false;
                    s4.LetID = let.LetID;
                    s4.Oznaka = "D" + (i + 1).ToString();
                    db.Sjediste.Add(s4);

                    Sjediste s5 = new Sjediste();
                    s5.isBussiness = false;
                    s5.isProzor = false;
                    s5.isZauzeto = false;
                    s5.LetID = let.LetID;
                    s5.Oznaka = "E" + (i + 1).ToString();
                    db.Sjediste.Add(s5);

                    Sjediste s6 = new Sjediste();
                    s6.isBussiness = false;
                    s6.isProzor = true;
                    s6.isZauzeto = false;
                    s6.LetID = let.LetID;
                    s6.Oznaka = "F" + (i + 1).ToString();
                    db.Sjediste.Add(s6);

                }
                db.SaveChanges();

            }



            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Let
        [ResponseType(typeof(Let))]
        public IHttpActionResult PostLet(Let let)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Let.Add(let);
            db.SaveChanges();

            Avion avion = db.Avion.Find(let.AvionID);
            for (int i = 0; i < avion.BrojSjedistaBuss/2; i++)
            {
                Sjediste s1 = new Sjediste();
                s1.isBussiness = true;
                s1.isProzor = true;
                s1.isZauzeto = false;
                s1.LetID = let.LetID;
                s1.Oznaka = "A" + (i + 1);

                db.Sjediste.Add(s1);

                Sjediste s2 = new Sjediste();
                s2.isBussiness = true;
                s2.isProzor = true;
                s2.isZauzeto = false;
                s2.LetID = let.LetID;
                s2.Oznaka = "B" + (i + 1);

                db.Sjediste.Add(s2);

            }


            for (int i = 0; i < avion.BrojSjedistaEco / 6; i++)
            {
                Sjediste s1 = new Sjediste();
                s1.isBussiness = false;
                s1.isProzor = false;
                s1.isZauzeto = false;
                s1.LetID = let.LetID;
                s1.Oznaka = "A" + (i + 1).ToString();
                db.Sjediste.Add(s1);

                Sjediste s2 = new Sjediste();
                s2.isBussiness = false;
                s2.isProzor = false;
                s2.isZauzeto = false;
                s2.LetID = let.LetID;
                s2.Oznaka = "B" + (i + 1).ToString();
                db.Sjediste.Add(s2);

                Sjediste s3 = new Sjediste();
                s3.isBussiness = false;
                s3.isProzor = true;
                s3.isZauzeto = false;
                s3.LetID = let.LetID;
                s3.Oznaka = "C" + (i + 1).ToString();
                db.Sjediste.Add(s3);

                Sjediste s4 = new Sjediste();
                s4.isBussiness = false;
                s4.isProzor = false;
                s4.isZauzeto = false;
                s4.LetID = let.LetID;
                s4.Oznaka = "D" + (i + 1).ToString();
                db.Sjediste.Add(s4);

                Sjediste s5 = new Sjediste();
                s5.isBussiness = false;
                s5.isProzor = false;
                s5.isZauzeto = false;
                s5.LetID = let.LetID;
                s5.Oznaka = "E" + (i + 1).ToString();
                db.Sjediste.Add(s5);

                Sjediste s6 = new Sjediste();
                s6.isBussiness = false;
                s6.isProzor = true;
                s6.isZauzeto = false;
                s6.LetID = let.LetID;
                s6.Oznaka = "F" + (i + 1).ToString();
                db.Sjediste.Add(s6);

            }
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = let.LetID }, let);
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