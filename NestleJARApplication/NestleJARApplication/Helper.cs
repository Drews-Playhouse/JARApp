
/* 
 * Drew Waszak 
 * D3 Application Developer
 * Date: 1/9/2020
 * This class handles the connection string and calls app.config to secure the entire conneciton string
 */
 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleJARApplication
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString; //calls App.config which gives the connection string and then returns the value
        }
    }
}
