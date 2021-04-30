using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejex_UserRegistration_Test
{
   public class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateFirstName("Shubham");
            Console.WriteLine(result);

            Pattern pattern1 = new Pattern();
            bool result1 = pattern1.ValidateLastName("Bodake");
            Console.WriteLine(result1);

            Pattern pattern2 = new Pattern();
            bool result2 = pattern2.ValidateEmail("Shubham@gmail.com");
            Console.WriteLine(result);

            Pattern pattern3 = new Pattern();
            bool result3 = pattern3.ValidateMobileNumber("91 7757929383");
            Console.WriteLine(result);

            Pattern pattern4 = new Pattern();
            bool result4 = pattern4.ValidatePassword("Shubhambodake");
            Console.WriteLine(result);

            Pattern pattern5 = new Pattern();
            bool result5 = pattern5.ValidatePasswordRule2("Shubham1234");
            Console.WriteLine(result);

            Pattern pattern6 = new Pattern();
            bool result6 = pattern6.ValidatePasswordRule3("Shubham@1345");
            Console.WriteLine(result);



            Console.ReadKey();
        }
    }
}
