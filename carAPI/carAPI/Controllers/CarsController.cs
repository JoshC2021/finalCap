using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using carAPI.Models;
//space

namespace carAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly AutomotiveDbContext _context;

        public CarsController(AutomotiveDbContext context)
        {
            _context = context;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
            return await _context.Cars.ToListAsync();
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }
/*  Testing FromQuery, was unsuccesful
        // GET: api/Cars/5
        [HttpGet("Search")]
        public async Task<ActionResult<Car>> SearchCar([FromQuery] string make = null, [FromQuery] string model = null, [FromQuery] string year = null, [FromQuery] string color = null)
        {
            IEnumerable<Car> query = _context.Cars;
            if(make is not null)
            {
                query = query.Where(x => x.Make.Contains(make));
            }
            if (model is not null)
            {
                query = query.Where(x => x.Model.Contains(model));
            }
            if (year is not null)
            {
                query = query.Where(x => x.Year.Contains(year));
            }
            if (color is not null)
            {
                query = query.Where(x => x.Color.Contains(color));
            }

            int matches = query.Count();
            if (matches > 0)
            {
                return await query.ToListAsync();
            }
            else
            {
                return NotFound();
            }
            
        }
*/
        // GET: api/Cars/Search/Make/Toyota
        [HttpGet("Make/{make}")]
        public async Task<ActionResult<IEnumerable<Car>>> SearchMake(string make)
        {
            int matches = _context.Cars.Count(x => x.Make.Contains(make));

            if(matches < 1)
            {
                return NotFound();
            }
       
            return await _context.Cars.Where(x => x.Make.Contains(make)).ToListAsync();
        }

        // GET: api/Cars/Search/Model/Camry
        [HttpGet("Model/{model}")]
        public async Task<ActionResult<IEnumerable<Car>>> SearchModel(string model)
        {
            int matches = _context.Cars.Count(x => x.Model.Contains(model));

            if (matches < 1)
            {
                return NotFound();
            }

            return await _context.Cars.Where(x => x.Model.Contains(model)).ToListAsync();
        }

        // GET: api/Cars/Search/Year/2002
        [HttpGet("Year/{year}")]
        public async Task<ActionResult<IEnumerable<Car>>> SearchYear(string year)
        {
            int matches = _context.Cars.Count(x => x.Year.Contains(year));

            if (matches < 1)
            {
                return NotFound();
            }

            return await _context.Cars.Where(x => x.Year.Contains(year)).ToListAsync();
        }

        // GET: api/Cars/Search/Color/Yellow
        [HttpGet("Color/{color}")]
        public async Task<ActionResult<IEnumerable<Car>>> SearchColor(string color)
        {
            int matches = _context.Cars.Count(x => x.Color.Contains(color));

            if (matches < 1)
            {
                return NotFound();
            }

            return await _context.Cars.Where(x => x.Color.Contains(color)).ToListAsync();
        }

        // PUT: api/Cars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
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

        // POST: api/Cars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { id = car.Id }, car);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}
