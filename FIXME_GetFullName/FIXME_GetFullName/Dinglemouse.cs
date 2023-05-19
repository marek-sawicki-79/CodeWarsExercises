using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIXME_GetFullName
{
    public class Dinglemouse
    {
        private string firstName;
        private string lastName;
        public string FullName
        {
            get
            {
                if (firstName == "") return lastName;
                else if (lastName == "") return firstName;
                else return $"{firstName} {lastName}";
            }
        }

        public Dinglemouse(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
