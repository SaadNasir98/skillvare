using SkillVare_WebApi.DB_Context;
using SkillVare_WebApi.Models;

namespace SkillVare_WebApi.Services
{

    public interface IUserSkill_Service
    {
        Task<bool> insertUserSkill(User_Skills param);
        Task<User_Skills> getUserSkill(int Id);
        Task<bool> updateUserSkill(int Id, User_Skills param);
        Task<bool> deleteUserSkill(int Id);
    }
    public class UserSkill_Service : IUserSkill_Service
    {
        ApplicationDbContext _context;
        public UserSkill_Service(ApplicationDbContext _context)
        {
            this._context  = _context;

        }

        public async Task<bool> deleteUserSkill(int Id)
        {
            var itemToDelete = await _context.User_Skills.FindAsync(Id);

            if (itemToDelete == null)
            {
                return false;
            }

            _context.User_Skills.Remove(itemToDelete);

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

        public async Task<User_Skills> getUserSkill(int Id)
        {
            try
            {
                var result = _context.User_Skills.FirstOrDefault(a => a.Id == Id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> insertUserSkill(User_Skills param)
        {
            try
            {
                var insert = await _context.User_Skills.AddAsync(param);

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

        public async Task<bool> updateUserSkill(int Id, User_Skills param)
        {
            var existingItem = await _context.User_Skills.FindAsync(param.Id);

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
