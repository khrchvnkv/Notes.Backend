using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Feedback
    {
        [Required, Display(Name = "Enter your Name")]
        public string UserName { get; set; }
        
        [Required, Display(Name = "Enter your Surname")]
        public string UserSurname { get; set; }
        
        [Required, Display(Name = "Enter your Age")]
        public int Age { get; set; }
        
        [Required, Display(Name = "Enter your Email address")]
        public string Email { get; set; }
        
        [Required, Display(Name = "Enter Message"),
        StringLength(30, ErrorMessage = "Too long message")]
        public string Message { get; set; }
    }
}