using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + this.Name);
            sb.Append("\n");
            if ((this.Age ?? -1) == -1)
            {
                sb.Append("Age: not specified");
            }
            else
            {
                sb.Append("Age: " + this.Age);
            }
            sb.Append("\n");

            return sb.ToString();
        }
    }
}
