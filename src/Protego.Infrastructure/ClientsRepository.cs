using Dapper;
using System.Data;
using Protego.Core.Abstractions.Factories;
using Protego.Core.Abstractions.Repositories;

namespace Protego.Infrastructure
{
    public class ClientsRepository(IDbConnectionFactory _dbConnectionFactory) : IClientsRepository
    {
        public async Task<int> AddClient(string username, byte[] passwordHash, string passwordSalt)
        {
            DynamicParameters parameters = new();

            parameters.Add("Username", username);
            parameters.Add("PasswordHash", passwordHash);
            parameters.Add("PasswordSalt", passwordSalt);

            using IDbConnection protegoDbConnection = _dbConnectionFactory.GetProtegoSqlServerDbConnection();

            return await protegoDbConnection.ExecuteAsync(sql: "proc_AddClient", param: parameters, commandType: CommandType.StoredProcedure);
        }
    }
}