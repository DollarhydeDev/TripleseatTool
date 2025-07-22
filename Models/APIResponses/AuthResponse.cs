using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class AuthResponse
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }

    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }
}
