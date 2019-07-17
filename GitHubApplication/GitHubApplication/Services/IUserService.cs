﻿using GitHubApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApplication.Services
{
    public interface IUserService
    {
        User Login(string login, string password);
        User Register(User user);
    }
}
