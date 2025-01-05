using System.Data;
using Microsoft.Data.SqlClient;
using Protego.Core.Abstractions.Factories;
using Protego.Core.Utilities.Configuration;

namespace Protego.Infrastructure
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection GetProtegoSqlServerDbConnection()
        {
            return new SqlConnection(AppSettings.ConnectionStrings!.ProtegoSqlServerDb);
        }
    }
}