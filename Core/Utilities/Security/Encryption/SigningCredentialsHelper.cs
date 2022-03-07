﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) //Credentials: Giriş bilgileri.
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature); //Hangi anahtar ve hangi algoritma kullanacağını belirtiyoruz!
        }
    }
}
