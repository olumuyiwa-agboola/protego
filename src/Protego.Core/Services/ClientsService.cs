using Protego.Core.Utilities;
using Protego.Core.Models.Clients;
using Protego.Core.Abstractions.Services;
using Protego.Core.Abstractions.Repositories;

namespace Protego.Core.Services
{
    public class ClientsService(IClientsRepository _clientsRepo) : IClientsService
    {
        public async Task<int> CreateClient(CreateClientRequest request)
        {
            // Decontruct request
            string username = request.Username;
            string password = request.Password;

            // Hash password and return appended salt 
            (byte[] passwordHash, string passwordSalt) = PasswordUtilities.HashPassword(password);

            // Save client to database
            var result = await _clientsRepo.AddClient(username, passwordHash, passwordSalt);

            return result;
        }
    }
}