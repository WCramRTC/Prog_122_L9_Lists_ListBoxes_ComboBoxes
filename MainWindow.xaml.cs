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
        List<string> studentNames = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            Preload(); // Call preload to load lists at start of application
            DisplayList(studentNames);
     
            
        
        } // MainWindow

        public void Preload()
        {
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


            studentsFavoriteColors.Remove("Will - white");
            // Adding names to my student list
            studentNames.Add("Dylan");
            studentNames.Add("Kristyn");
            studentNames.Add("Hannah");
        }

        // Method will display my list of colors to my rich text box
        public void DisplayList()
        {
            rtbDisplay.Text = ""; // This will clear the text box

            for (int i = 0; i < studentsFavoriteColors.Count; i++)
            {
                string currentColor = studentsFavoriteColors[i];
                rtbDisplay.Text += currentColor + "\n";
            }

        } // DisplayList()

        public void DisplayList(List<string> list)
        {
            //rtbDisplay.Text = ""; // This will clear the text box

            for (int i = 0; i < list.Count; i++)
            {
                string currentColor = list[i];
                rtbDisplay.Text += currentColor + "\n";
            }
        }

        public void DisplayList(List<string> list1, List<string> list2)
        {
            rtbDisplay.Text = ""; // This will clear the text box

            for (int i = 0; i < list1.Count; i++)
            {
                string currentColor = list1[i];
                rtbDisplay.Text += currentColor + "\n";
            }

            for (int i = 0; i < list2.Count; i++)
            {
                string currentColor = list2[i];
                rtbDisplay.Text += currentColor + "\n";
            }
        }

        // Refactor our code to make our method more efficent

        public void ExampleCode()
        {
            List<bool> bools = new List<bool>();
            bools.Add(true);
            bools.Add(true);
            bools.Add(true);
            bools.Add(true);
            bools.Add(true);
            bools.Add(true);
            bools.Add(true);
            bools.Add(true);
            bools.Add(true);
            // Get the .Count
            //rtbDisplay.Text = "";

            //for(int i = 0; i < listOfDoubles.Length ; i++)
            //{
            //    rtbDisplay.Text += i + " : " + listOfDoubles[i] + "\n";
            //}


            // Display List
            //DisplayList();
            DisplayList(studentNames);
            rtbDisplay.Text = "";
            DisplayList(studentsFavoriteColors);

            rtbDisplay.Text = "Count : " + bools.Count + "\n";
            rtbDisplay.Text += "Capacity : " + bools.Capacity;


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


        // Add
        // Access a single elements
        // Remove

    } // class

} // namespace
