using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateListing.Models;

namespace RealEstateListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstatesController : ControllerBase
    {
        private readonly RealEstateListingContext _context;

        public RealEstatesController(RealEstateListingContext context)
        {
            _context = context;
        }

        // GET: api/RealEstates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RealEstate>>> GetRealEstate()
        {
            return await _context.RealEstate.ToListAsync();
        }

        // GET: api/RealEstates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RealEstate>> GetRealEstate(int id)
        {
            var realEstate = await _context.RealEstate.FindAsync(id);

            if (realEstate == null)
            {
                return NotFound();
            }

            return realEstate;
        }

        // PUT: api/RealEstates/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRealEstate(int id, RealEstate realEstate)
        {
            if (id != realEstate.Id)
            {
                return BadRequest();
            }

            _context.Entry(realEstate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RealEstateExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RealEstates
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RealEstate>> PostRealEstate(RealEstate realEstate)
        {
            _context.RealEstate.Add(realEstate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRealEstate", new { id = realEstate.Id }, realEstate);
        }

        // DELETE: api/RealEstates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RealEstate>> DeleteRealEstate(int id)
        {
            var realEstate = await _context.RealEstate.FindAsync(id);
            if (realEstate == null)
            {
                return NotFound();
            }

            _context.RealEstate.Remove(realEstate);
            await _context.SaveChangesAsync();

            return realEstate;
        }

        private bool RealEstateExists(int id)
        {
            return _context.RealEstate.Any(e => e.Id == id);
        }


        [HttpPut("buy/{id}")]
        public ActionResult<RealEstate> BuyHouse([FromRoute]int id, [FromBody] BuyModel buy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var house = _context.RealEstate.Find(id);
            if (house == null)
            {
                return BadRequest();
            }
            house.BuyDate = DateTime.Now;
            _context.SaveChanges();
            return Ok(house);
        }
    }
}
