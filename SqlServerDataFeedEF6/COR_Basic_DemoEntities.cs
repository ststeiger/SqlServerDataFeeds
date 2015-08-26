
namespace SqlServerDataFeedEF6
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    // http://cosairus.com/Blog/2015/3/10/programmatic-connection-strings-in-entity-framework-6
    // The Step They Didn't Tell You 
    public partial class COR_Basic_DemoEntities : DbContext
    {
        public COR_Basic_DemoEntities(string connectionString)
            : base(connectionString)
        {

        }
    }

}
