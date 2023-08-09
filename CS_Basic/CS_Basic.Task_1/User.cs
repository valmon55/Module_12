﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basic.Task_1
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }
    }
}
