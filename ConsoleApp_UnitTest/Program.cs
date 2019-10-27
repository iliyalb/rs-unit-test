using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_UnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public string GetFullName(string firstName, string lastName)
        {
            return (firstName.Trim() + " " + lastName.Trim()).Trim(); 
        }
    }
}
