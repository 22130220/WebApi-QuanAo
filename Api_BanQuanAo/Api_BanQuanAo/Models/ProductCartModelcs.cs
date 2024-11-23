using System.ComponentModel.DataAnnotations;

namespace Api_BanQuanAo.Models
{
    public class ProductCartModelcs
    {
        [Required]
        public String UserId { get; set; } = null!;
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Soluong { get; set; }
    }
}
