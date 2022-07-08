using FastLearnersMVCWebApplication.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace FastLearnersMVCWebApplication.Extentions
{
    public static class ConvertExtentions
    {
        public static List<SelectListItem> ToSelectList<T>(this IEnumerable<T> collection, int selectedValue = 0) where T : IPrimaryProperties
        {
            return (from item in collection
                    select new SelectListItem
                    {
                        Text = item.Title,
                        Value = item.Id.ToString(),
                        Selected = (selectedValue == item.Id)
                    }).ToList();
        }
    }
}
