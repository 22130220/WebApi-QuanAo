using Api_BanQuanAo.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_BanQuanAo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCartController : ControllerBase
    {
        private QuanaoContext _context;

        public ProductCartController(QuanaoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productincart>>> GetProducts()
        {
            return await _context.Productincarts.ToListAsync();
        }

        //[HttpPost]
        //public async Task<ActionResult<Productincart>> PostProduct(String userId, int productID)
        //{

        //    //var product = _context.Products.FindAsync(productID);
        //    //var user = _context..FindAsync(userId);

        //    //if(product == null || user == null)
        //    //{
        //    //    return BadRequest(new
        //    //    {
        //    //        Message = "Thêm không hợp lệ"
        //    //    });
        //    //}

        //    //Productincart pr = new Productincart
        //    //{
        //    //    ProductId = productID,
        //    //    UserId = userId,
        //    //    Quantity = 0
        //    //};

        //    //_context.Productincarts.Add(pr);
        //    //try
        //    //{
        //    //    await _context.SaveChangesAsync();
        //    //}
        //    //catch (DbUpdateException e)
        //    //{

        //    //    return Conflict(e.GetBaseException);

        //    //}

        //    //return CreatedAtAction("GetProduct", new { Userid = pr.UserId, ProductID = pr.ProductId }, pr);
        //}

    }
}
