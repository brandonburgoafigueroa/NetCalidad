using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    class Person
    {
        string m_FName;
        string m_LName;
        int m_Age;
        float m_cash;

        Person()
        {
            m_FName = "";
            m_LName = "";
            m_Age = 0;
            m_cash = 0;
        }

        public Person(string strFName, string strLName, int iAge)
        {
            m_FName = strFName;
            m_LName = strLName;
            m_Age = iAge;
            m_cash = 100000;
        }



        public int Age
        {
            get { return m_Age; }
        }

        public string FullName
        {
            get { return m_FName + " " + m_LName; }
        }

        public float CashBalance
        {
            get { return m_cash; }
        }


        public bool BuyCar(float fCost)
        {
            m_cash = m_cash + fCost;
            if (m_cash >= 0)
                return true;
            else
                return false;
        }
    }
}
