using System.Data.Common;
using System.Reflection.Emit;

namespace Solid.D
{
    public class DependecyInversionPrinciple
    {
        
    }

    interface IDbConnection
    {
        public void Connect();
    }

    class MySqlConnection : IDbConnection
    {
        public void Connect()
        {
            throw new System.NotImplementedException();
        }
    }
    
    class OracleConnection : IDbConnection
    {
        public void Connect()
        {
            throw new System.NotImplementedException();
        }
    }
    
    class SqlServer : IDbConnection
    {
        public void Connect()
        {
            throw new System.NotImplementedException();
        }
    }

    class PasswordReminder
    {
        private string dbConnection;

        public PasswordReminder(IDbConnection dbConnection)
        {
            this.dbConnection = this.dbConnection;
        }
    }
}