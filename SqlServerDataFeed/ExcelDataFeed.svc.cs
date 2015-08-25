
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
