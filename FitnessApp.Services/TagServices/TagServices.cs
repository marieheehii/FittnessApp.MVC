using FitnessApp.Data;
using FitnessApp.Data.Data;
using FitnessApp.Models.Models.Tag;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Services.TagServices
{
    public class TagServices : ITagServices
    {
        private readonly ApplicationDbContext _context;

        public TagServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddTagToDB(TagsModel tag)
        {
            if(tag == null )
            {
                return false;
            }
            else
            {
                var entity = new Tags
                {
                    TagValue = tag.TagValue,
                };

                _context.Tagses.Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> DeleteTag(int tagId)
        {
            var tag = await _context.Tagses.FindAsync(tagId);
            if (tag == null) return false;

            _context.Remove(tag);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<TagsModel>> GetAllTags()
        {
            var tags = await _context.Tagses.Select(t => new TagsModel
            {
                Id = t.Id,
                TagValue = t.TagValue,
            }).ToListAsync();
            return tags;
        }

        public async Task<TagsModel> GetTag(int tagId)
        {
            var tag = await _context.Tagses.FindAsync(tagId);
            if (tag == null) return null;

            return new TagsModel
            {
                Id = tag.Id,
                TagValue = tag.TagValue,
            };
        }
    }
}
