using Api_BanQuanAo.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_BanQuanAo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly QuanaoContext context;

        public ProductController(QuanaoContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this.context.Products.ToList());
        }
    }
}
