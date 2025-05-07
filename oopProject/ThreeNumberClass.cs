using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    internal class ThreeNumberClass
    {
        private int num1;
        private int num2;
        private int num3;

        public int FindLargest (int n1,int n2, int n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;

            if (num1 > num2 && num1 > num3)
                return num1;
            else if (num2 > num1 && num2 > num3)
                return num2;
            else return num3;

        }

        public int FindSmallest(int n1, int n2, int n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
            if (num1 < num2 && num1 < num3)
                return num1;
            else if (num2 < num1 && num2 < num3)
                return num2;
            else return num3;
        }

        public int FindTotal(int n1, int n2, int n3)
        {
            int sum = 0;
            num1 = n1;
            num2 = n2;
            num3 = n3;
            sum = num1 + num2 + num3;
            return sum;
        }

        public int FindAverage(int n1, int n2, int n3)
        {
            int average = 0;
            num1 = n1;
            num2 = n2;
            num3 = n3;
            average = (num1 + num2 + num3) / 3;
            return average;
        }

    }
}
