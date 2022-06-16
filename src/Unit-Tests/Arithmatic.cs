using System;
using System.Collections.Generic;

namespace Unit_Tests
{
    public class Arithmatic
    {
        public List<int> NumList = new List<int>();

        public int AddNumber(int num1, int num2){ // Numbers must arbitrarily be above 0 to practice some exception handling!
            if(num1 > 0 && num2 > 0){
                int result = num1 + num2;
                return result;
            }
            else {
                throw new ArgumentException($"Numbers entered - {num1} and {num2} not valid. Numbers must be greater than 0");
            }

        }

        public int MultNumber(int num1, int num2){ // Numbers must arbitrarily be above 0 to practice some exception handling!
            if(num1 > 0 && num2 > 0){
                int result = num1 * num2;
                return result;
            }
            else {
                throw new ArgumentException($"Numbers entered - {num1} and {num2} not valid. Numbers must be greater than 0");
            }
        }

        public void NumberToList(int num1){
            NumList.Add(num1);
        }
    }
}