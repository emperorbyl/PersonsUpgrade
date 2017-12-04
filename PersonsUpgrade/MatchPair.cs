using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsUpgrade
{
    public abstract class MatchPair
    {
        public Person personA { get; set; }
        public Person personB { get; set; }
        public abstract bool Match( Person person1, Person person2);
        
    }
}
