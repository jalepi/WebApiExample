using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<TargetDefinitionStatus> DefineTarget(ITargetDefined target);
    }

    public interface ITargetDefined
    {
    }

    public enum TargetDefinitionStatus
    {
        Ok,
    }
}
