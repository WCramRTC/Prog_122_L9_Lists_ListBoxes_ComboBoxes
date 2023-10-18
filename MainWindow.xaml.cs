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

namespace Prog_122_L9_Lists_ListBoxes_ComboBoxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // New of Students Favorite colors


        // Hafsa - Black
        // Matthew - Orange
        // Benel - Green
        // David -  pink
        // Kira - Purple
        // Juan - Light cornflower blue
        // Manjula - Red
        List<string> studentsFavoriteColors = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            // A list uses indexs
            // A collection always STARTS at 0



            // To add to a list, you do listName.Add(object)
            // .Add()
            // When you ADD an item to the list, it add's it one after another
                                                           // Index    Element
            studentsFavoriteColors.Add("Hafsa - Black"); //     0        1 
            studentsFavoriteColors.Add("Matthew - Orange"); //  1        2
            studentsFavoriteColors.Add("Benel - Green"); //     2        3
            studentsFavoriteColors.Add("David - Pink ");
            studentsFavoriteColors.Add("Kira - Purple");
            studentsFavoriteColors.Add("Juan - Light Cornflower Blue");
            studentsFavoriteColors.Add("Manjula - Red");
            studentsFavoriteColors.Add("Will - White");

            // 10

            // Get the .Count
            rtbDisplay.Text = "";
            
            //for(int i = 0; i < listOfDoubles.Length ; i++)
            //{
            //    rtbDisplay.Text += i + " : " + listOfDoubles[i] + "\n";
            //}


        } // MainWindow

        public void ExampleCode()
        {
            bool[] listOfDoubles = new bool[10];


            //rtbDisplay.Text = studentsFavoriteColors[6];

            //rtbDisplay.Text = "Hafsa's favorite color is black";
            //rtbDisplay.Text += "\nMatthew's favorite color is orange";
        }

        // A Collection in programming is any
        // Data Structure that holds multiple
        // Variables of the same type

        // Array or List

        // List<type> listName = new List<type>();
        // Create a list of student names
        // We need to keep track of a first and a last name
        List<string> studentNames = new List<string>();

        // Add
        // Access a single elements
        // Remove

    } // class

} // namespace
