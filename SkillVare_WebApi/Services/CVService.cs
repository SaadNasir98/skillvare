using SkillVare_WebApi.DB_Context;
using SkillVare_WebApi.Models;

namespace SkillVare_WebApi.Services
{

    public interface ICVService
    {
        Task<bool> insertCVTemplate(CVTemplate param);
        Task<CVTemplate> getCVTemplate(int Id);
        Task<bool> updateCVTemplate(int Id, CVTemplate param);
        Task<bool> deleteCVTemplate(int Id);
    }
    public class CVService : ICVService
    {
        ApplicationDbContext _context;

        public CVService(ApplicationDbContext _context)
        {
            this._context = _context;
        }



        public async Task<CVTemplate> getCVTemplate(int Id)
        {
            try
            {
                var result =  _context.CVTemplate.FirstOrDefault(a => a.Id == Id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> insertCVTemplate(CVTemplate param)
        {
            try
            {
                var insert = await _context.CVTemplate.AddAsync(param);

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

        public async Task<bool> updateCVTemplate(int Id, CVTemplate param)
        {
            var existingItem = await _context.CVTemplate.FindAsync(param.Id);

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

        public async Task<bool> deleteCVTemplate(int Id)
        {
            var itemToDelete = await _context.CVTemplate.FindAsync(Id);

            if (itemToDelete == null)
            {
                return false;
            }

            _context.CVTemplate.Remove(itemToDelete);

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
