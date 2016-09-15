using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProgrammingExample
{
    class clsMyClass
    {
        private int m_intHeight;
        private const long dropsInABucket = 1000000;

        public int Height 
        {
            get
            {
                return m_intHeight;
            }
            set
            {
                if (value >= 10) 
                    m_intHeight = value;
            }
        }

        public long AddTwoNumbers(int intNumber1, int intNumber2)
        {
            return intNumber1 + intNumber2;
        }

        public long DropsInABucket
        {
            get
            {
                return dropsInABucket;
            }
        }
    }
}
