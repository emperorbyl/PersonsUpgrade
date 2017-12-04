using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsUpgrade
{
    public class NameMatch : MatchPair
    {
        NameMatch(Person person1, Person person2)
        {
            personA = person1;
            personB = person2;
        }

        public override bool Match(Person person1, Person person2)
        {
            bool isMatch = false;
            try
            {
                if (person1.FirstName == person2.FirstName && person1.MiddleName == person2.MiddleName && person1.LastName == person2.LastName)
                    isMatch = true;
            }
            catch (Exception e)
            {

            }
            return isMatch;
        }
    }
}
