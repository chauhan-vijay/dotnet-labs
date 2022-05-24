namespace CustomConfigurationFile.Api.Models
{
    public class ErrorMessages
    {
        public const string SectionName = "ErrorMessages";

        public string NotFound { get; set; } = string.Empty;

        public string Conflict { get; set; } = string.Empty;

        public string Other { get; set; } = string.Empty;
    }
}
