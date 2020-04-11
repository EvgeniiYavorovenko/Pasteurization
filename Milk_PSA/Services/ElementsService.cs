using Milk_PSA.DataAccess.Interfaces;
using Milk_PSA.Models;
using Milk_PSA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk_PSA.Services
{
    public class ElementsService : IElementsService
    {
        private IElementsDA _elementsDA;

        public ElementsService(IElementsDA elementsDA)
        {
            _elementsDA = elementsDA;
        }

        public LogResponse[] GetLog()
        {
            var result = _elementsDA.GetLog();
            return result;
        }

        public LogResponse[] UpdateStatus(UpdateStatusRequest request, int ID)
        {
            var result = _elementsDA.UpdateStatus(request, ID);
            return result;
        }
    }
}
