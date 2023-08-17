using System.Text.Json.Serialization;

namespace Authorization.Entity
{
    public class LoginResponse : IResponseBase
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("folio")]
        public string folio { get; set; }
    }
}
