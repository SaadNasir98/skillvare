using System.ComponentModel.DataAnnotations.Schema;

namespace SkillVare_WebApi.Models
{
    
    public class SkillCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool isRetable { get; set; }
    }

   
  
}
