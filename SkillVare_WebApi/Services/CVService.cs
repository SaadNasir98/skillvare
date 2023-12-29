using SkillVare_WebApi.DB_Context;
using SkillVare_WebApi.Models;

namespace SkillVare_WebApi.Services
{

    public interface ICVService
    {
        Task<bool> insertCVTemplate(CV_Template param);
        Task<CV_Template> getCVTemplate(int Id);
        Task<bool> updateCVTemplate(int Id, CV_Template param);
        Task<bool> deleteCVTemplate(int Id);
    }
    public class CVService : ICVService
    {
        ApplicationDbContext _context;

        public CVService(ApplicationDbContext _context)
        {
            this._context = _context;
        }



        public async Task<CV_Template> getCVTemplate(int Id)
        {
            try
            {
                var result =  _context.CV_Template.FirstOrDefault(a => a.Id == Id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> insertCVTemplate(CV_Template param)
        {
            try
            {
                var insert = await _context.CV_Template.AddAsync(param);

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

        public async Task<bool> updateCVTemplate(int Id, CV_Template param)
        {
            var existingItem = await _context.CV_Template.FindAsync(param.Id);

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
            var itemToDelete = await _context.CV_Template.FindAsync(Id);

            if (itemToDelete == null)
            {
                return false;
            }

            _context.CV_Template.Remove(itemToDelete);

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
