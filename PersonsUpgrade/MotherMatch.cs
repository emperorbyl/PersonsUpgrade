using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsUpgrade
{
    public class MotherMatch : MatchPair
    {
        public override bool Match( Person person1, Person person2)
        {
            bool isMatch = false;
            try
            {
                if (person1.MotherFirstName == person2.MotherFirstName && person2.MotherMiddleName == person1.MotherMiddleName && person1.MotherLastName == person2.MotherLastName)
                    isMatch = true;
            }
            catch(Exception e)
            {}
            return isMatch;
        }
        public MotherMatch(Person person1, Person person2)
        {
            personA = person1;
            personB = person2;
        }
    }
}
