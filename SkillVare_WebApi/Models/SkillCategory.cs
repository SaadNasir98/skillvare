﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SkillVare_WebApi.Models
{
    
    public class SkillCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool isRetable { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }

   
  
}
