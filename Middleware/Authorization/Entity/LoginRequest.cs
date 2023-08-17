using System.Text.Json.Serialization;

namespace Authorization.Entity
{
    public class LoginRequest : IRequestBase
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
