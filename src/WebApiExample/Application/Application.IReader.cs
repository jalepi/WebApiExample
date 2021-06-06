using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Application.DataObjecs;

namespace WebApiExample.Application
{
    public interface IReader
    {
        Task<bool> DoesCartonExist(DoesCartonExist doesIt);
    }
}
