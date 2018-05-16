using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    public class Person
    {
        string Fname;
        string Lname;
        int _age;
        float _cash;

        public Person()
        {
            Fname = "";
            Lname = "";
            _age = 0;
            _cash = 0;
        }

        public Person(string Fname, string Lname, int Age)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            _age = Age;
            _cash = 100000;
        }



        public int Age
        {
            get { return _age; }
        }

        public string FullName
        {
            get { return Fname + " " + Lname; }
        }

        public float CashBalance
        {
            get { return _cash; }
        }


        public bool BuyCar(float Cost)
        {
            //_cash = _cash + Cost;
            _cash = _cash - Cost;
            if (_cash >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
