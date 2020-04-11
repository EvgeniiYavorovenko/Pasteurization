using Milk_PSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk_PSA.Services.Interfaces
{
    public interface IElementsService
    {
        LogResponse[] GetLog();
        public LogResponse[] UpdateStatus(UpdateStatusRequest request, int ID);
    }
}
