

namespace AppTeachSolu.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Services
    {
        [Key]
        [Display(Name = "Service Id")]
        public int ServiceId { get; set; }
        [Display(Name ="Service Name")]
        [StringLength(50)]
        public string ServiceName { get; set; }
        
        public string description { get; set; }
        [Display(Name ="Is Available")]
        public bool IsAvailable { get; set; }
        [Display(Name ="Publish On")]
        public DateTime PublishOn { get; set; }

    }
}
