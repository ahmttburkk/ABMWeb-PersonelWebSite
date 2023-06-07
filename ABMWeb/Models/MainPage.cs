using System.ComponentModel.DataAnnotations;

namespace ABMWeb.Models
{
    public class MainPage
    {
        [Key]
        public int Id { get; set; }
        public string? Profile { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string Explanation { get; set; }
        public string? Experiences { get; set; }
        public string? Social { get; set; }
    }
}
