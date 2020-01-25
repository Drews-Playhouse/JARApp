/* 
 * Drew Waszak 
 * D3 Application Developer
 * Date: 1/9/2020
 * Main Script for the UI
 */
using Dapper;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NestleJARApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void View2_Click(object sender, RoutedEventArgs e)  //Pops open the manual entry window
        {
            window2 win2 = new window2();
            win2.ShowDialog();
        }
        private void Explorer_Click(object sender, RoutedEventArgs e) //opens up a folder explorer for the user to choose their folder location
        {
            //Process.Start("explorer.exe", @"C:\Users");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = null; //This shows the files avaible when FE is opened
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames) //loops through each file that is opened and appends them to projectField2 listbox
                    projectField2.Items.Add(System.IO.Path.GetFileName(filename));
            }
        }

        private void importButton_Click(object sender, RoutedEventArgs e)
        {
            //DataAccess db = new DataAccess();
            //db.testFunction();
            

            //string connectionString = projectField2.SelectedItem.ToString(); //Gets the Database file as a string from the user
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("sampleDB")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();
                //string lastName = "Lloyd";
                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                var output = connection.Query<BOM>("SELECT name FROM sys.Tables").ToList();
                for(int i = 0; i < output.Count; i++)
                {
                    sqlTables.Items.Add(output[i]);
                }
                //sqlTables.Items.Add(output);
            }
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
