﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PhotoPortal.Services.Interfaces.Services;

namespace PhotoPortal.Services.Interfaces.Factories
{
    public interface IServiceFactory
    {
        IUserService UserService { get; }

        IPhotoService PhotoService { get; }

        IEncryptionService EncryptionService { get; }

        IAuthenticationService AuthenticationService { get; }
    }
}