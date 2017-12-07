using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonsUpgrade
{
    public abstract class Output
    {
        public StreamWriter output { get; set; }
        public abstract void DecideOutput(StreamWriter stream);
        public void Write(string data)
        {
            output.Write(data);
        }
    }
}
