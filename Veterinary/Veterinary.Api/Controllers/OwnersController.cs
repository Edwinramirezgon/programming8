﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinary.Api.Data;
using Veterinary.Shared.Entities;

namespace Veterinary.Api.Controllers
{
    [ApiController]
    [Route("/api/owners")]
    public class OwnersController : ControllerBase
    {

        private readonly DataContext _context;

        public OwnersController(DataContext context)
        {


            _context = context;
        }


        //Metodo Get lista 
        [HttpGet]

        public async Task<ActionResult> Get()
        {


            return Ok(await _context.Owners.ToListAsync());
        }


        //Metodo Get id
        [HttpGet("id:int")]

        public async Task<ActionResult> Get(int id)
        {
            var owner = await _context.Owners.FirstOrDefaultAsync(x => x.Id==id);

            if (owner == null)
            {

                return NotFound();
            }
            else
            {

                return Ok(owner);
            }
        }

        [HttpPost]  
        public async Task<ActionResult> Post(Owner owner)
        {

            _context.Add(owner);

            await _context.SaveChangesAsync();

            return Ok(owner);
        }

        [HttpPut]
        public async Task<ActionResult> put(Owner owner)
        {

            _context.Update(owner);

            await _context.SaveChangesAsync();

            return Ok(owner);
        }

        [HttpDelete("id:int")]

        public async Task<ActionResult> Delete(int id)
        {
            var owner = await _context.Owners.FirstOrDefaultAsync(x => x.Id == id);
            var FilasAfectadas = await _context.Owners.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {

                return NotFound();
            }
            else
            {

                return NoContent();
            }
        }
    }
}
