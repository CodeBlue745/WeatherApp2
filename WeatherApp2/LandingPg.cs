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
    public partial class LandingPg : Form
    {
        Dictionary<string, getItems> dict1 = new Dictionary<string, getItems>();

        public LandingPg()
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
                Cbox1.Items.Add(Contents[0]);
                //Here, we add some items to a dictionary for later use.
                //dict1.Add(Contents[0], new getItems(Contents));

            }
            inputFile.Close();
        }

        private void Cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbox1.SelectedIndex > 0)
                {
                    //turn on random number generator.
                    Random generator = new Random();
                    //I will need a converter for displaying dates and time for the sunset and sunrise.
                    var date1 = new DateTime();
                    //Put the random number into a string and assigns a randnumbetween 5 and 100.
                    string randTemp = generator.Next(-20, 100).ToString() + "◦F";
                    string randKnot = generator.Next(0, 231).ToString() + "mph";
                    string randDir = generator.Next(5, 100).ToString() + "";
                    string randPressure = generator.NextDouble() * 1000 + "millibars";
                    string randHumid = generator.Next(30, 95).ToString() + "%";
                    string randRiseNum = generator.Next(5, 100).ToString() + "am";
                    string randRiseDate = date1.ToString();
                    string randSetNum = generator.Next(5, 100).ToString() + "pm";
                    string randSetDate = date1.ToString();

                    listView1.Items.Add(randTemp);
                    LvSpeed.Items.Add(randKnot);
                    LvDirection.Items.Add(randDir);
                    LvPressure.Items.Add(randPressure);
                    LvHumidity.Items.Add(randHumid);
                    LvSunrise.Items.Add(randRiseDate);
                    LvSunset.Items.Add(randSetDate);


                    ///If the Combobox item is selected.
                    ///Display a random temperature in listView1
                }
            }
            catch { MessageBox.Show("Error processing that city."); }
            
            
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
