using System.ComponentModel.DataAnnotations;

namespace PaypathWeb.Models
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }
    }
}
