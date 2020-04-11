using Milk_PSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk_PSA.DataAccess.Interfaces
{
    public interface IParameterDA
    {
        ParametersResponse[] IncrementAndGetParameter(double temp, int lvl, int i);
        string CheckAccess(int ID);
        int[] EditOptimalParameters(int level, double temperature);
        StarterRequest[] GetProcessParameters();
        public GetOptimalParameters[] GetOptimalParameters();
    }
}
