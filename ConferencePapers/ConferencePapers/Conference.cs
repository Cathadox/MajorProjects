using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePapers
{
    public class Conference
    {
        public string id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
       public Conference(string n, int y)
        {
            id = Guid.NewGuid().ToString();
            Name = n;
            Year = y;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1}", Year, Name);
        }
        public int getYear()
        {
            return Year;
        }
    }
}
