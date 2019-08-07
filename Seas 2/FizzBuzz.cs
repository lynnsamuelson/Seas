using System;
using Seas;



namespace Seas
{

    
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            var csv = new CSV();
            csv.ParseCSV();

        }

        public string FizzBuzzMethod(int value, int fizz, int buzz)
        {
            var result = value.ToString();

            if(value % fizz == 0 && value % buzz == 0)
            {
                return "FizzBuzz";
            }

            if(value % fizz == 0)
            {
               
                return "Fizz";
            }

            if(value % buzz == 0)
            {
              
                return "Buzz";
            }


            return result;

        }
        
    }
}
