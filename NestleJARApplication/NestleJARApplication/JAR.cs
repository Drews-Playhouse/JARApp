/* 
 * Drew Waszak 
 * D3 Application Developer
 * Date: 1/9/2020
 * This class handles what information is being passed from the data base to the UI 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestleJARApplication
{
    public class Person //Demo Class from Sample Database filled with this data
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get
            {
                // "Drew Waszak (test@test.com)"
                return $"{ FirstName } { LastName } ({ EmailAddress })";
            }
        }

    }
    public class BOM //Will fill the BOM information into this class
    {
        public int PnPID { get; set; }
        public string Tag { get; set; }
        public string Type { get; set; }
        public string EquipmentSpec { get; set; }
        public double Weight { get; set;  }
        public string MaterialsOfConstruction { get; set; }
        public int number { get; set; }
        public string Area { get; set; }

    }
}
