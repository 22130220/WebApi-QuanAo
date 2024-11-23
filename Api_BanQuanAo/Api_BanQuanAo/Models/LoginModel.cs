using System.ComponentModel.DataAnnotations;

namespace Api_BanQuanAo.Models
{
    public class LoginModel
    {
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }


        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
    }
}
