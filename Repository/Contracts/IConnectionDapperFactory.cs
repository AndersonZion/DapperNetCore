using System.Data;

namespace Repository.Contracts
{
    public interface IConnectionDapperFactory
    {
        IDbConnection Connection();
    }
}
