using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Models
{
    class CustomerList

    {
      
        public string Name { get; set; }
        public int Age { get; set; }

        public CustomerList(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
