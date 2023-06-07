using System.ComponentModel.DataAnnotations;

namespace ABMWeb.Models
{
    public class AdminPage
    {
        [Key]
        public int Id { get; set; }
        //public string AdminName { get; set; }
        //public string Password { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}
