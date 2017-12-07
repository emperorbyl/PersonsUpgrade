using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsUpgrade
{
    class ConsoleOutput : Output
    {
        public override void DecideOutput(StreamWriter stream)
        {
            output = stream;
            output.AutoFlush = true;
            Console.SetOut(output);
        }
    }
}
