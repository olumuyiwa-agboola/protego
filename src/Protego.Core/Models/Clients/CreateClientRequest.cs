namespace Protego.Core.Models.Clients
{
    public class CreateClientRequest
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}