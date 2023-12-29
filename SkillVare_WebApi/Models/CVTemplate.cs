namespace SkillVare_WebApi.Models
{
    public class CVTemplate
    {
        public int Id { get; set; }
        public string? TemplateName { get; set; }
        public string? TemplatePath { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
