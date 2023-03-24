using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Authentification.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}

