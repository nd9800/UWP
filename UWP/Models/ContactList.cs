using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Models
{
    class ContactList
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public ContactList(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }
}
