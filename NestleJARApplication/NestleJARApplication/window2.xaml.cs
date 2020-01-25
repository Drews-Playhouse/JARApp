/* 
 * Drew Waszak 
 * D3 Application Developer
 * Date: 1/9/2020
 * Window 2 Script for the manual entry UI
 */
using System;
using System.Collections.Generic;
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
    public partial class window2 : Window
    {
        public window2()
        {
            InitializeComponent();
        }
        public void CheckRB_Click(object sender, RoutedEventArgs e) //function that handles which Radio Button has been selected
        {
            if (ManualRB.IsChecked == true)
            {
                MessageBox.Show("Manual has been selected");
            }

            if (PlantRB.IsChecked == true)
            {
                MessageBox.Show("Plant has been selected");
            }
        }

        public void DropDownMenu_Click(object sender, RoutedEventArgs e)
        {
            //Function that handles the properties drop down menu
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }
        //displays a new property field for the user Dynamically
        public void p1_Click(object sender, RoutedEventArgs e)
        {
            //Initialize new fields to use
            var newTextBox = new TextBox();
            var newTextBlock = new TextBlock();
            //Populate fields
            newTextBox.Text = "Vendor";
            newTextBlock.Text = "Vendor";
            //Add fields to UI Dynamically 
            propertiesPanel.Children.Add(newTextBox);
            propertiesPane2.Children.Add(newTextBlock);
        }
        public void p2_Click(object sender, RoutedEventArgs e)
        {
            //Initialize new fields to use
            var newTextBox = new TextBox();
            var newTextBlock = new TextBlock();
            //Populate fields
            newTextBox.Text = "Glossary term";
            newTextBlock.Text = "Glossary term";
            //Add fields to UI Dynamically 
            propertiesPanel.Children.Add(newTextBox);
            propertiesPane2.Children.Add(newTextBlock);
        }
        public void p3_Click(object sender, RoutedEventArgs e)
        {
            //Initialize new fields to use
            var newTextBox = new TextBox();
            var newTextBlock = new TextBlock();
            //Populate fields
            newTextBox.Text = "Pricing Estimated";
            newTextBlock.Text = "Pricing Estimated";
            //Add fields to UI Dynamically 
            propertiesPanel.Children.Add(newTextBox);
            propertiesPane2.Children.Add(newTextBlock);
        }
        public void p4_Click(object sender, RoutedEventArgs e)
        {
            //Initialize new fields to use
            var newTextBox = new TextBox();
            var newTextBlock = new TextBlock();
            //Populate fields
            newTextBox.Text = "Pricing Actual";
            newTextBlock.Text = "Pricing Actual";
            //Add fields to UI Dynamically 
            propertiesPanel.Children.Add(newTextBox);
            propertiesPane2.Children.Add(newTextBlock);
        }
    }
}

