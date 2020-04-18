using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp2
{
    //Here, we create the class parameters.
    public class getItems
    {
        //this class has a private string.
        private string _getRandNum;
        //Now, we are defining what the class does
        public getItems(string[] Contents)
        {
            _getRandNum = Contents[0];
        }

        public string RandGenerator
        {
            get { return _getRandNum; }
            set { _getRandNum = value; }
        }
    }
}
