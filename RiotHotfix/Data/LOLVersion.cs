namespace RiotHotfix.Data
{
    public class LOLVersion
    {
        public string? Version { get; set; }
        public string? Link { get; set; }
        public string? Link2 { get; set; }
        public string? Status { get; set; }
        public string? UpdateDate { get; set; } = DateTime.Now.ToString();
    }
}
