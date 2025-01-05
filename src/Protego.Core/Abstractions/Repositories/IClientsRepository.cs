namespace Protego.Core.Abstractions.Repositories
{
    public interface IClientsRepository
    {
        Task<int> AddClient(string username, byte[] passwordHash, string passwordSalt);
    }
}