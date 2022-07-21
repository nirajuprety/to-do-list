using System.ComponentModel.DataAnnotations;

namespace todolist.Models
{
    public class Items
    {

        [Required]
        public int Id { get; set; }
        [Required]

        public string ItemTitle { get; set; }


        [Required]
        public string ItemTag { get; set; }
        [Required]

        [DataType(DataType.Text)]
        public string ItemDescription { get; set; }


    }
}
