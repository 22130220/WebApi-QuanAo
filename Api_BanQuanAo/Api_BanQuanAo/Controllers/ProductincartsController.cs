using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_BanQuanAo.Entities;
using Api_BanQuanAo.Models;
using Microsoft.AspNetCore.Authorization;

namespace Api_BanQuanAo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductincartsController : ControllerBase
    {
        private readonly QuanaoContext _context;

        public ProductincartsController(QuanaoContext context)
        {
            _context = context;
        }

        // GET: api/Productincarts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productincart>>> GetProductincarts()
        {
            return await _context.Productincarts.ToListAsync();
        }

        [HttpGet("getAuthor")]
        [Authorize]
        public async Task<IActionResult> GetAuthorize()
        {
            return Ok(new
            {
                Message = "Sucess"
            });
        }

        // GET: api/Productincarts/5
        [HttpGet("inCart/{id}")]
        public async Task<List<Productincart>> Getincart(string id)
        {
            var productincart = await _context.Productincarts.Where(p => p.UserId == id).ToListAsync();
            return productincart;
        }

        //[HttpGet("ProductinCart/{id}")]
        //public async Task<List<Product>> GetProductincart(string id)
        //{
        //    var productincart = await _context.Productincarts.Where(p => p.UserId == id).ToListAsync();
        //    List<Product> productInCartUser = new List<Product>();

        //    foreach (Productincart cartUser in productincart)
        //    {
        //        var temp = _context.Products.Where(p => p.Id == cartUser.ProductId);
        //        foreach (var item in temp)
        //        {
        //            productInCartUser.Add(item);
        //        }
        //    }
        //    return productInCartUser;
        //}

        // PUT: api/Productincarts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductincart(string id, Productincart productincart)
        {
            if (id != productincart.UserId)
            {
                return BadRequest();
            }

            _context.Entry(productincart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductincartExists(id))
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

        // POST: api/Productincarts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostProductincart(String userId, int productID)
        {

            //var productidex = await _context.FindAsync<Product>(productID);
            //var useridex = await _context.FindAsync<Aspnetuser>(userId);

            //if (productidex == null || useridex == null)
            //{
            //    return BadRequest(new
            //    {
            //        Message = "Thêm không hợp lệ"
            //    });
            //}

            Productincart pr = new Productincart
            {
                   ProductId = productID,
                   UserId = userId,
                   Quantity = 0

            };
            _context.Productincarts.Add(pr);
          
            await _context.SaveChangesAsync();
            return Ok(new
            {
                Message = "Add product into cart success"
            });
        }

        // DELETE: api/Productincarts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductincart(string id)
        {
            var productincart = await _context.Productincarts.FindAsync(id);
            if (productincart == null)
            {
                return NotFound();
            }

            _context.Productincarts.Remove(productincart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductincartExists(string id)
        {
            return _context.Productincarts.Any(e => e.UserId == id);
        }
    }
}
