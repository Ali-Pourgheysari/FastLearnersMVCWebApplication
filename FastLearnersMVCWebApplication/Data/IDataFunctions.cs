using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastLearnersMVCWebApplication.Entities;

namespace FastLearnersMVCWebApplication.Data
{
    public interface IDataFunctions
    {
        Task UpdateUserCategoryEntityAsync(List<UserCategory> userCategoryItemsToDelete, List<UserCategory> userCategoryItemsToAdd);
    }
}
