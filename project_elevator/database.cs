using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_elevator
{
    internal class database
    {
        public string Connection() // method to connect the data to database
        {
            string url = "datasource=localhost; Database=Elevator; port=3306; User=root; Password=123456";
            return url;
        }
    }
}
