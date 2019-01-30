using System.ComponentModel.DataAnnotations;

namespace TravelPartners.Models
{
    public class UserRequestModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only english letters are allowed.")]
        [StringLength(128, ErrorMessage = "The FirstName can not be more then 128 letters!")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only english letters are allowed.")]
        [StringLength(128, ErrorMessage = "The FirstName can not be more then 128 letters!")]
        public string LastName { get; set; }
        [Required]
        [StringLength(128, ErrorMessage = "The FirstName can not be more then 128 letters!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }
}