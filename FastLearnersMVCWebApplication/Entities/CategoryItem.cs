using FastLearnersMVCWebApplication.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastLearnersMVCWebApplication.Entities
{
    public class CategoryItem
    {
        private DateTime _releasedDate = DateTime.MinValue;
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int MediaTypeId { get; set; }
        [NotMapped]
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateTimeItemReleased 
        {
            get
            {
                return (_releasedDate == DateTime.MinValue) ? DateTime.Now : _releasedDate;
            }
            set
            {
                _releasedDate = value;
            }
        }
        [NotMapped]
        public int ContentId { get; set; }

    }
}
