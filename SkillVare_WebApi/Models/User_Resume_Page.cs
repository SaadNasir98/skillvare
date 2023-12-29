namespace SkillVare_WebApi.Models
{
    public class User_Resume_Page
    {
        public int Id { get; set; }
        public int UserResumeID { get; set; }
        public int? PageNo { get; set; }
        public string Education { get; set; }
        public string WorkExperience { get; set; }
        public string UserIntroduction { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
