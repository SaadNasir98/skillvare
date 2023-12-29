using SkillVare_WebApi.DB_Context;
using SkillVare_WebApi.Models;

namespace SkillVare_WebApi.Services
{

    public interface ISkillcategory_Service
    {
        Task<bool> insertSkillcategory(SkillCategory param);
        Task<SkillCategory> getSkillcategory(int Id);
        Task<bool> updateSkillcategory(int Id, SkillCategory param);
        Task<bool> deleteSkillcategory(int Id);
    }
    public class Skillcategory_Service : ISkillcategory_Service
    {
        ApplicationDbContext _context;

        public Skillcategory_Service(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public async Task<bool> deleteSkillcategory(int Id)
        {
            var itemToDelete = await _context.SkillCategory.FindAsync(Id);

            if (itemToDelete == null)
            {
                return false;
            }

            _context.SkillCategory.Remove(itemToDelete);

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<SkillCategory> getSkillcategory(int Id)
        {
            try
            {
                var result =   _context.SkillCategory.FirstOrDefault(a => a.Id == Id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> insertSkillcategory(SkillCategory param)
        {
            try
            {
                var insert = await _context.SkillCategory.AddAsync(param);
                
                if (param == null)
                {
                    return false;
                }
                else
                {
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> updateSkillcategory(int Id, SkillCategory param)
        {
            var existingItem = await _context.SkillCategory.FindAsync(param.Id);

            if (existingItem == null)
            {
                return false;
            }
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
