
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SqlServerDataFeedEF6
{


    public partial class Default : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            // Beautiful example
            COR_Basic_DemoEntities Repo = new COR_Basic_DemoEntities(ExcelDataFeed.GetEntityConnectionString());


            string strSQL = @"
SELECT 
	 BE_Vorname
	,BE_Name 
	,BE_User 
	,Name 
	,COUNT(Name) AS qty 
	,SUM(1) AS summe 
FROM T_Benutzer 

LEFT JOIN T_Benutzer_Benutzergruppen
	ON T_Benutzer_Benutzergruppen.BEBG_BE = BE_ID 
	
LEFT JOIN T_Benutzergruppen 
	ON ID = BEBG_BG 
	
WHERE BE_ID <> 1234 

GROUP BY 
	 BE_Vorname
	,BE_Name 
	,BE_User 
	,Name 
	
ORDER BY Name, BE_User, qty, summe 
";

            int __UserId = 1234;
            /*
            var ls = (
                from QueryToGroup in
                (
                    from users in Repo.T_Benutzer
                    from mappings in Repo.T_Benutzer_Benutzergruppen
                            .Where(mapping => mapping.BEBG_BE == users.BE_ID)
                            .DefaultIfEmpty() // <== makes join left join
                    from groups in Repo.T_Benutzergruppen
                            .Where(gruppe => gruppe.ID == mappings.BEBG_BG)
                            .DefaultIfEmpty() // <== makes join left join         
                    where users.BE_ID != __UserId

                    select new
                    {
                         Vorname = users.BE_Vorname
                        ,Name = users.BE_Name
                        ,UserName = users.BE_User
                        ,GroupName = groups.Name
                        //,abc = 1
                    }
                )
                group QueryToGroup by new { QueryToGroup.Vorname, QueryToGroup.Name, QueryToGroup.UserName, QueryToGroup.GroupName } into g
                select new 
                { 
                     Vorname = g.Key.Vorname
                    ,Name = g.Key.Name
                    ,Nutzer = g.Key.UserName
                    ,Gruppe = g.Key.GroupName
                    //,qty = g.Count( x => x.GroupName != null)
                    ,qty = g.Select(x=> x.GroupName).Count()
                    //,Count = g.Select(x => x.GroupName).Distinct().Count()

                    // ,summe = g.Sum(x => x.abc)
                }

            ).ToList();
            */

            var lol = (
                from users in Repo.T_Benutzer
                from mappings in Repo.T_Benutzer_Benutzergruppen
                        .Where(mapping => mapping.BEBG_BE == users.BE_ID)
                        .DefaultIfEmpty() // <== makes join left join
                from groups in Repo.T_Benutzergruppen
                        .Where(gruppe => gruppe.ID == mappings.BEBG_BG)
                        .DefaultIfEmpty() // <== makes join left join         
                where users.BE_ID != __UserId

                select new
                {
                     Vorname = users.BE_Vorname
                    ,Name = users.BE_Name
                    ,UserName = users.BE_User
                    ,GroupName = groups.Name
                    //,value = 1
                }
                    into QueryToGroup
                    group QueryToGroup by new { QueryToGroup.Vorname, QueryToGroup.Name, QueryToGroup.UserName, QueryToGroup.GroupName } into g

                // orderby g.Key.GroupName, g.Key.UserName, g.Count(x => x.GroupName != null)

                select new
                {
                    Vorname = g.Key.Vorname
                    ,Name = g.Key.Name
                    ,Nutzer = g.Key.UserName
                    ,Gruppe = g.Key.GroupName
                    //,qty = g.Count(x => x.GroupName != null)
                    //,qty = g.Select(x => x.GroupName).Where(x => x != null).Count()
                    ,qty = g.Select(x => x.GroupName).Where(x => x != null).Distinct().Count()
                    //, a = g.Select(x => x.value).Distinct().Count()

                    //,a = g.Select(x => x.GroupName !=  null).Count()
                    
                    //,qty = g.Select(x => x.GroupName != null).Count()
                    //,Count = g.Select(x => x.GroupName).Distinct().Count()
                    // ,summe = g.Sum(x => x.abc)
                }

            )
            // .OrderBy(t => t.Gruppe).ThenBy(t => t.Nutzer).ThenBy(t => t.qty) // Order in SQL
            .ToList()
            .OrderBy(t => t.Gruppe).ThenBy(t => t.Nutzer).ThenBy(t => t.qty) // Order in .NET
            ;


            System.Console.WriteLine(strSQL);
            // System.Console.WriteLine(ls);
            System.Console.WriteLine(lol);
        }


    }


}
