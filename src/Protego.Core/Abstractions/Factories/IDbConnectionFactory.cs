using System.Data;

namespace Protego.Core.Abstractions.Factories
{
    public interface IDbConnectionFactory
    {
        IDbConnection GetProtegoSqlServerDbConnection();
    }
}