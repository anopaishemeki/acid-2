using System.ComponentModel.DataAnnotations;

namespace PaypathWeb.Models
{
    public class ContactForm
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone No is Required")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Subject is Required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Message is Required")]
        public string Message { get; set; }
    }
}
