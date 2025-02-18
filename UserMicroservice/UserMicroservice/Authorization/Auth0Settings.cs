namespace UserMicroservice.Authorization;

public class Auth0Settings
{
    public required string Domain { get; set; }
    public required string Audience { get; set; }
}
