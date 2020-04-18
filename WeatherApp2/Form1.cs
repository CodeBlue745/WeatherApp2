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
            Cbox1Load()
        }
        private void Cbox1Load()
        {
            //Set Select as the Cb first word to load.
            Cbox1.Items.Add("Select");
            //Set the filename string variable to an escape sequence.
            string filename = @"C:\Users\Administrator\source\repos\WeatherApp2\WeatherApp2\bin\Debug\WorldCities.txt";
            //We will open the file text using the filepath, or escape sequence. //also, assign this to readerVar to be called.
            StreamReader inputFile = File.OpenText(filename);
            //Use StreamReader to see if you're at the end of the file.
            while (!inputFile.EndOfStream)
            {

                string[] stringList1;
                
                
                stringList1 = filename.Split('\n');
                //Here, we chuck all the city names into a combobox for dropdown funcionality.
                Cbox1.Items.Add(stringList1);

                //break to get out of the loop.
                break;
            }
        }

        private void Cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
