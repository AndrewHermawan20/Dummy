using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;
using Dummy.DatabaseSpecific;

namespace Dummy_Service;

public class ServiceInitializer
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