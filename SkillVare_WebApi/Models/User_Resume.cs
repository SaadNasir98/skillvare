namespace SkillVare_WebApi.Models
{
    public class User_Resume
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int TemplateId { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
