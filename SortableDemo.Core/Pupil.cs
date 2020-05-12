using System;
using System.Collections.Generic;
using System.Text;

namespace OwnArrayList.Core
{
    public class Pupil
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private int _catalogNumber;

        public int CatalogNumber
        {
            get { return _catalogNumber; }
            set { _catalogNumber = value; }
        }

        public Pupil() : this(999, "Max", "Mustermann", 999)
        {
        }

        public Pupil(int catalogNr, string firstName, string lastName, int age)
        {
            _catalogNumber = catalogNr;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }
    }
}