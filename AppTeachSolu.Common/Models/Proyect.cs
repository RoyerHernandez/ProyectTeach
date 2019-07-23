
namespace AppTeachSolu.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;


    public class Proyect
    {
        [Key]
        public int ProyectId { get; set; }
        [Required]
        public string description { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime PublishOn { get; set; }

    }
}
