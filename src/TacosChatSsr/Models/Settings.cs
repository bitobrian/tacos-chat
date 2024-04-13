namespace TacosChatSsr.Models;

public class Settings
{
    public int Id { get; set; }
    public string TwitchClientId { get; set; } = "";
    public string TwitchClientSecret { get; set; } = "";
    public string TwitchUserAccessToken { get; set; } = "";
    public string TwitchUserName { get; set; } = "";
    public string ProfileName { get; set; } = "";
}