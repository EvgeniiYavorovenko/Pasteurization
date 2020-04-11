using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Milk_PSA.Models;

namespace Milk_PSA.Services.Interfaces
{
    public interface IParametersService
    {
        ParametersResponse[] AutoMode(double temp, int lvl, int i);
        string CheckAccess(int ID);
        public int[] EditOptimalParameters(int level, double temperature);
        StarterRequest[] GetProcessParameters();
        public GetOptimalParameters[] GetOptimalParameters();
    }
}
