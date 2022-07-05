using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastLearnersMVCWebApplication.Entities
{
    public class MediaType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        public string ThumbnailImagePath { get; set; }
        [ForeignKey("MediaTypedId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
