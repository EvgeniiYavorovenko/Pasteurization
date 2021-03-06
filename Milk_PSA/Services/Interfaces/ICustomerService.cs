﻿using Milk_PSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk_PSA.Services.Interfaces
{
    public interface ICustomerService
    {
        int? RegisterCustomer(RegisterCustomerRequest request);
        LoginResponse LoginCustomer(LoginRequest request);
        CustomerInfo GetCustomerInfo(GetCustomerInfoRequest request);
    }
}
