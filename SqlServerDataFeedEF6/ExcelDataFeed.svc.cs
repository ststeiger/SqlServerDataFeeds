
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

// With EntityFramework 6:
// The server encountered an error processing the request. 
// The exception message is 'On data context type 'AddProjectModel', there is a top IQueryable property 'Assets' 
// whose element type is not an entity type. Make sure that the IQueryable property 
// is of entity type or specify the IgnoreProperties attribute on the data context type to ignore this property.
// See server logs for more details. 
// http://stackoverflow.com/questions/25873290/wcf-odata-service-and-ef-6-issue-cant-expose-entities-using-odata-service
// http://blogs.msdn.com/b/odatateam/archive/2013/10/02/using-wcf-data-services-5-6-0-with-entity-framework-6.aspx

// Replace DataService with EntityFrameworkDataService, say in your WcfDataService1.svc:
// public class WcfDataService1 : EntityFrameworkDataService

// Install-Package Microsoft.OData.EntityFrameworkProvider -Pre

namespace SqlServerDataFeedEF6
{


    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ExcelDataFeed : System.Data.Services.Providers.EntityFrameworkDataService<COR_Basic_DemoEntities>
    {

        //// Unnecessary
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
