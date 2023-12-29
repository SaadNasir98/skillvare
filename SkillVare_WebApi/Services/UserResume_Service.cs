using SkillVare_WebApi.DB_Context;
using SkillVare_WebApi.Models;

namespace SkillVare_WebApi.Services
{
    public interface IUserResume_Service
    {
        Task<bool> insertUserResume(User_Resume param);
        Task<User_Resume> getUserResume(int Id);
        Task<bool> updateUserResume(int Id, User_Resume param);
        Task<bool> deleteUserResume(int Id);
    }

    public class UserResume_Service : IUserResume_Service
    {
        ApplicationDbContext _context;
        public UserResume_Service(ApplicationDbContext _context) 
        { 
            this._context = _context;
        }

        public async Task<bool> deleteUserResume(int Id)
        {
            var itemToDelete = await _context.user_Resumes.FindAsync(Id);

            if (itemToDelete == null)
            {
                return false;
            }

            _context.user_Resumes.Remove(itemToDelete);

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

        public async Task<User_Resume> getUserResume(int Id)
        {
            try
            {
                var result = _context.user_Resumes.FirstOrDefault(a => a.Id == Id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> insertUserResume(User_Resume param)
        {
            try
            {
                var insert = await _context.user_Resumes.AddAsync(param);

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

        public async Task<bool> updateUserResume(int Id, User_Resume param)
        {
            var existingItem = await _context.user_Resumes.FindAsync(param.Id);

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
