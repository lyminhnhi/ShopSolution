﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.ViewModels.Users
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberUser { get; set; }
    }
}
