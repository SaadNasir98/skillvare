using SkillVare_WebApi.DB_Context;
using SkillVare_WebApi.Models;

namespace SkillVare_WebApi.Services
{
    public interface IUserResume_PageService
    {
        Task<bool> insertUserResume_Page(User_Resume_Page param);
        Task<User_Resume_Page> getUserResume_Page(int Id);
        Task<bool> updateUserResume_Page(int Id, User_Resume_Page param);
        Task<bool> deleteUserResume_Page(int Id);
    }
    public class UserResume_PageService : IUserResume_PageService
    {
        ApplicationDbContext _context;

        public UserResume_PageService(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public async Task<bool> deleteUserResume_Page(int Id)
        {
            var itemToDelete = await _context.User_Resume_Page.FindAsync(Id);

            if (itemToDelete == null)
            {
                return false;
            }

            _context.User_Resume_Page.Remove(itemToDelete);

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

        public async Task<User_Resume_Page> getUserResume_Page(int Id)
        {
            try
            {
                var result = _context.User_Resume_Page.FirstOrDefault(a => a.Id == Id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> insertUserResume_Page(User_Resume_Page param)
        {
            try
            {
                var insert = await _context.User_Resume_Page.AddAsync(param);

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

        public async Task<bool> updateUserResume_Page(int Id, User_Resume_Page param)
        {
            var existingItem = await _context.User_Resume_Page.FindAsync(param.Id);

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
