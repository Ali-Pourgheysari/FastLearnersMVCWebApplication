using System;
using System.ComponentModel.DataAnnotations;

namespace FastLearnersMVCWebApplication.Entities
{
    public class CategoryItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public int MediaTypeId { get; set; }
        [Required]
        public DateTime DateTimeItemReleased { get; set; }

    }
}
