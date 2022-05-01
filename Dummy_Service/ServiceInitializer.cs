using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Dummy_Data;
using Dummy.DatabaseSpecific;

namespace Dummy_Service
{
    public static class ServiceInitializer
    {
        public static void Initialize(ServiceConfigurationArgs args)
        {
            ServiceContext.DatabaseConnectionString = args.DatabaseConnectionString;

            RuntimeConfiguration.AddConnectionString(
                        DataAccessAdapter.ConnectionStringKeyName,
                        args.DatabaseConnectionString);

            RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(
                c =>
                {
                    c.AddDbProviderFactory(typeof(System.Data.SqlClient.SqlClientFactory));
                    c.SetDefaultCompatibilityLevel(SqlServerCompatibilityLevel.SqlServer2012);
                });
        }
    }
}
