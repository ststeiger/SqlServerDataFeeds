using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlServerDataFeeds
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Request JSON:
            // Add 'application/json' to the Accept header.
            // Append $format to the original URL, e.g., ~/Employees?$format=application/json

            // Now in the latest ODL(6.3), only json is supported for payloads except metadata document.

            try
            {
                Request.Headers.Remove("Accept");
            }
            catch { }

            try
            {
                Request.Headers.Add("Accept", "application/atom+xml");
            }
            catch { }

        }




        public static string GetFlagDescription(int flag)
        {
            string vcRet = null;

            // Flag: 
            // SUM
            // (
            // 	CASE 
            // 		WHEN PRIVILEGE_TYPE = 'SELECT' THEN 1 
            // 		WHEN PRIVILEGE_TYPE = 'INSERT' THEN 2 
            // 		WHEN PRIVILEGE_TYPE = 'UPDATE' THEN 4 
            // 		WHEN PRIVILEGE_TYPE = 'DELETE' THEN 8 
            // 		ELSE 100
            // 	END
            // ) AS Flag 

            switch (flag)
            {
                case 0:
                    vcRet = "N";
                    break;
                case 1:
                    vcRet = "S";
                    break;
                case 2:
                    vcRet = "I";
                    break;
                case 3:
                    vcRet = "SI";
                    break;
                case 4:
                    vcRet = "U";
                    break;
                case 5:
                    vcRet = "SU";
                    break;
                case 6:
                    vcRet = "IU";
                    break;
                case 7:
                    vcRet = "SIU";
                    break;
                case 8:
                    vcRet = "D";
                    break;
                case 9:
                    vcRet = "SD";
                    break;
                case 10:
                    vcRet = "ID";
                    break;
                case 11:
                    vcRet = "SID";
                    break;
                case 12:
                    vcRet = "UD";
                    break;
                case 13:
                    vcRet = "SUD";
                    break;
                case 14:
                    vcRet = "IUD";
                    break;
                case 15:
                    vcRet = "SIUD";
                    break;
            }

            // SELECT UPDATE INSERT DELETE (SUID) 
            vcRet = Replace(Replace(Replace(Replace(vcRet, "D", "DELETE "), "S", "SELECT "), "U", "UPDATE "), "I", "INSERT ");
            vcRet = Trim(vcRet);
            vcRet = Replace(vcRet, " ", "\r\n");

            return vcRet;
        }


        public static string Trim(string str)
        {
            if (str == null)
                return str;

            return str.Trim();
        }


        public static string Replace(string str, string old, string replacement)
        {
            if (str == null)
                return str;

            return str.Replace(old, replacement);
        }



    }
}