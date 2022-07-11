﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastLearnersMVCWebApplication.Entities
{
    public class Content
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name = "HTML Content")]
        public string HTMLContent { get; set; }
        [Display(Name = "Video Link")]
        public string VideoLink { get; set; }
        public CategoryItem CategoryItem { get; set; }
        [NotMapped]
        public int CatItemId { get; set; }
        [NotMapped]
        public int CategoryId { get; set; }
    }
}
