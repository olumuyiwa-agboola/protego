using Protego.Core.Models.Clients;

namespace Protego.Core.Abstractions.Services
{
    public interface IClientsService
    {
        Task<int> CreateClient(CreateClientRequest client);
    }
}
