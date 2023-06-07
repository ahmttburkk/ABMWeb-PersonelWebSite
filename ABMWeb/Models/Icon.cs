using System.ComponentModel.DataAnnotations;

namespace ABMWeb.Models
{
    public class Icon
    {
        [Key]
        public int Id { get; set; }
        public string IconName { get; set; }
        public string IconLink { get; set; }
    }
}
