﻿using App2.BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Service.Abstraction
{
   public interface IAuthenticatorService
    {
        User connexion(string username, string password);
    }
}
