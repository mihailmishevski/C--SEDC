﻿using Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    public interface IUserService
    {
        void LogIn(User user);

        void PrintInfromation(User user);
    }
}
