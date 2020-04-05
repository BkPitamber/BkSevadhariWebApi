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
using BkSevadhariWebApi.Models;

namespace BkSevadhariWebApi.Controllers
{
    public class SevaDhariMastersController : ApiController
    {
        private BkSevadhariEntities db = new BkSevadhariEntities();

        // GET: api/SevaDhariMasters
        //public IQueryable<SevaDhariMaster> GetSevaDhariMasters()
         public List<SevaDhariMaster> GetSevaDhariMasters()
        {
            return db.SevaDhariMasters.ToList();
        }

        // GET: api/SevaDhariMasters/5
        [ResponseType(typeof(SevaDhariMaster))]
        public IHttpActionResult GetSevaDhariMaster(int id)
        {
            SevaDhariMaster sevaDhariMaster = db.SevaDhariMasters.Find(id);
            if (sevaDhariMaster == null)
            {
                return NotFound();
            }

            return Ok(sevaDhariMaster);
        }

        // PUT: api/SevaDhariMasters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSevaDhariMaster(int id, SevaDhariMaster sevaDhariMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sevaDhariMaster.SmId)
            {
                return BadRequest();
            }

            db.Entry(sevaDhariMaster).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SevaDhariMasterExists(id))
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

        // POST: api/SevaDhariMasters
        [ResponseType(typeof(SevaDhariMaster))]
        public IHttpActionResult PostSevaDhariMaster(SevaDhariMaster sevaDhariMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SevaDhariMasters.Add(sevaDhariMaster);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sevaDhariMaster.SmId }, sevaDhariMaster);
        }

        // DELETE: api/SevaDhariMasters/5
        [ResponseType(typeof(SevaDhariMaster))]
        public IHttpActionResult DeleteSevaDhariMaster(int id)
        {
            SevaDhariMaster sevaDhariMaster = db.SevaDhariMasters.Find(id);
            if (sevaDhariMaster == null)
            {
                return NotFound();
            }

            db.SevaDhariMasters.Remove(sevaDhariMaster);
            db.SaveChanges();

            return Ok(sevaDhariMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SevaDhariMasterExists(int id)
        {
            return db.SevaDhariMasters.Count(e => e.SmId == id) > 0;
        }
    }
}