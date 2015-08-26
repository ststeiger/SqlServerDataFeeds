
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;


using System.ServiceModel;


// https://msdn.microsoft.com/en-us/vs2010trainingcourse_buildingappandservicesusingodatavs2010_topic3.aspx
// http://stackoverflow.com/questions/12148977/wcf-data-service-request-error

namespace SqlServerDataFeed
{

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ExcelDataFeed : DataService<COR_Basic_DemoEntities>
    {


        //// Unnecessary...
        //public static void ModifyEntityConnectionString()
        //{
        //    System.Data.SqlClient.SqlConnectionStringBuilder csb = new System.Data.SqlClient.SqlConnectionStringBuilder();
        //    System.Data.EntityClient.EntityConnectionStringBuilder ecb = new System.Data.EntityClient.EntityConnectionStringBuilder();


        //    ecb.Metadata = "res://*/Sample.csdl|res://*/Sample.ssdl|res://*/Sample.msl";
        //    ecb.Provider = "System.Data.SqlClient";
        //    ecb.ProviderConnectionString = csb.ConnectionString;

        //    // COR_Basic_DemoEntities dataContext = new COR_Basic_DemoEntities(ecb.ConnectionString);
        //}


        public static string GetConnectionString()
        {
            System.Data.SqlClient.SqlConnectionStringBuilder csb = new System.Data.SqlClient.SqlConnectionStringBuilder();
            csb.DataSource = Environment.MachineName;
            csb.InitialCatalog = "COR_Basic_Demo";
            csb.IntegratedSecurity = true;
            csb.ApplicationName = "SqlServerDataFeed";

            if (!csb.IntegratedSecurity)
            {
                csb.UserID = "";
                csb.Password = "";
            }

            return csb.ConnectionString;
        }


        protected override COR_Basic_DemoEntities CreateDataSource()
        {
            //COR_Basic_DemoEntities ctx = new COR_Basic_DemoEntities(connectionString);
            COR_Basic_DemoEntities ctx = new COR_Basic_DemoEntities();
            ctx.Database.Connection.ConnectionString = GetConnectionString();

            return ctx;
        }


        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.UseVerboseErrors = true;
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);


            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            // config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead);
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }


    }
}
