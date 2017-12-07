using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsUpgrade
{
    class DefaultMatch : MatchPair
    {
        public DefaultMatch(Person person1, Person person2)
        {
            personA = person1;
            personB = person2;
        }

        public override bool Match(Person person1, Person person2)
        {
            bool isMatch = false;
            try
            {
                if (person1.Equals(person2))
                    isMatch = true;
            }
            catch (Exception e)
            {

            }
            return isMatch;
        }
    }
}
