using FastLearnersMVCWebApplication.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastLearnersMVCWebApplication.Entities
{
    public class Category : IPrimaryProperties
    {
        public int Id { get; set; }
        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "Thumbnail Image Path")]
        public string ThumbnailImagePath { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategories { get; set; }
    }
}
