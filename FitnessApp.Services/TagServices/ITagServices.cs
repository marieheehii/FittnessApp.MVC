using FitnessApp.Models.Models.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.TagServices
{
    public interface ITagServices
    {
        Task<bool> AddTagToDB(TagsModel tag);
        Task<IEnumerable<TagsModel>> GetAllTags();
        Task<TagsModel> GetTag(int tagId);
        Task<bool> DeleteTag(int tagId);
    }
}
