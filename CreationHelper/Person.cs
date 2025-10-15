using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace CreationHelper
{
    internal class Person
    {
        private string _person;

        public Person(string person) 
        {
            this._person = person;
        }

        public string Person_Definition { get { return _person; } }
    }
}
