namespace SkillVare_WebApi.Models
{
    public class User_Skills
    {
        public int Id { get; set; }
        public int UserResumeID { get; set; }
        public int UserID { get; set; }
        public int Skill_ID { get; set; }
        public int? Rating { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
