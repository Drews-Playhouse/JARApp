/* 
 * Drew Waszak 
 * D3 Application Developer
 * Date: 1/9/2020
 * This class handles the connection to the database and makes query calls to get information from the database
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Documents;

namespace NestleJARApplication
{
    class DataAccess
    {
        /*
        public List testFunction()
        {
            //string connectionString = projectField2.SelectedItem.ToString(); //Gets the Database file as a string from the user
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("sampleDB")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();
                //string lastName = "Lloyd";
                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                var output = connection.Query<BOM>("SELECT name FROM sys.Tables").ToList();
                //sqlTables.Items.Add(output);
            }
        }
        */
        public List<Person> GetPeople(string lastName, string connectionValue)
        {
            connectionValue = "sampleDB";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(connectionValue)))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Person> people = new List<Person>();

                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);

            }
        }
    }
}
