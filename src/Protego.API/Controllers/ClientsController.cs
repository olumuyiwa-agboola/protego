using Microsoft.AspNetCore.Mvc;
using Protego.Core.Models.Clients;
using Protego.Core.Abstractions.Services;

namespace Protego.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController(IClientsService _clientsService) : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateClient([FromBody] CreateClientRequest request)
        {
            return Ok(await _clientsService.CreateClient(request));
        }
    }
}
