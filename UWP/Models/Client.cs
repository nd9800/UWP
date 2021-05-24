﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Models
{
    class Client
    {
        private string email;
        private string title;
        private string content;

        public Client(string email, string title, string content)
        {
            Email = email;
            Title = title;
            Content = content;
        }

        public string Email
        {
            get => email;
            set => email = value;
          
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
        public string Content
        {
            get => content;
            set => content = value;
        }
    }
}
