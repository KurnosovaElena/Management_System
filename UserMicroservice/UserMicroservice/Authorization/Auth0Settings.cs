namespace UserMicroservice.Authorization;

public class Auth0Settings
{
    public const string SectionName = "Auth0";
    public required string Domain { get; set; }
    public required string Audience { get; set; }
}
