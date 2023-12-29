namespace SkillVare_WebApi.Responce
{
    public class ApiResponse
    {
        public int Count { get; set; }
        public int status_code { get; set; }
        public string Message { get; set; }
        public object data { get; set; }
    }
}
