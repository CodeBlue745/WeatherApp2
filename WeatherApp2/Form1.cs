using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeatherApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cbox1Load();
        }
        private void Cbox1Load()
        {
            //Set Select as the Cb first word to load.
            Cbox1.Items.Add("Select");
            Cbox1.SelectedIndex = 0;
            //Set the filename string variable to an escape sequence.
            string filename = @"C:\Users\Administrator\source\repos\WeatherApp2\WeatherApp2\bin\Debug\WorldCities";
            //Create a string-list Contents to be called later for the filename.
            string[] Contents;
            //This is where the majic happens. //We will open the file text using the filepath, or escape sequence. 
            StreamReader inputFile = File.OpenText(filename);
            //Use StreamReader to see if you're at the end of the file.
            while (!inputFile.EndOfStream)
            {
                //Add each city to a string-list called contents.
                Contents = inputFile.ReadLine().Split('\n');
                //Here, we chuck all the city names into a combobox for dropdown funcionality.
                Cbox1.Items.Add(Contents);
            }
            inputFile.Close();
        }

        private void Cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
