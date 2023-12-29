using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using SkillVare_WebApi.DB_Context;
using SkillVare_WebApi.Models;

namespace SkillVare_WebApi.Services
{
    public interface ISkillsServices
    {
        Task<bool> insertSkill(Skills param);
        Task<Skills> getSkill(int Id);
        Task<bool> updateSkill(int Id, Skills param);
        Task<bool> deleteSkill(int Id);
    }


    public class SkillsServices : ISkillsServices
    {
        ApplicationDbContext _context;

        public SkillsServices(ApplicationDbContext _context)
        {
            this._context = _context;
        }

       

        public async Task<Skills> getSkill(int Id)
        {
            try
            {
                var result = _context.Skills.FirstOrDefault(a => a.Id == Id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> insertSkill(Skills param)
        {
            try
            {
                var insert = await _context.Skills.AddAsync(param);
                
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

        public async Task<bool> updateSkill(int Id, Skills param)
        {
            var existingItem = await _context.Skills.FindAsync(param.Id);

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

        public async Task<bool> deleteSkill(int Id)
        {
            var itemToDelete = await _context.Skills.FindAsync(Id);

            if (itemToDelete == null)
            {
                return false;
            }

            _context.Skills.Remove(itemToDelete);

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
