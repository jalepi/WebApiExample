using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial class CartonHandler
    {
        public async Task<ItemReceivementStatus> AddItems(ItemsSent items)
        {
            try
            {
                if (await reader.DoesCartonExist(new DataObjecs.DoesCartonExist { }))
                {
                    return ItemReceivementStatus.CartonNotFound;
                }

                await writer.AddItems(new DataObjecs.AddItems 
                { 
                });

                return ItemReceivementStatus.Ok;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to add items");
                return ItemReceivementStatus.Unknown;
            }
        }

        public Task<CartonCreatedStatus> CreateCarton(CartonCreated carton)
        {
            throw new NotImplementedException();
        }

        public Task<TargetDefinitionStatus> DefineTarget(TargetDefined target)
        {
            throw new NotImplementedException();
        }

        public Task<(CartonStatus result, CartonDetails carton)> GetCarton(GetCartonQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<(CartonsStatus result, Cartons cartons)> GetCartons(GetCartonsQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<CartonStatusState> UpdateCartonState(CartonStateUpdated cartonState)
        {
            throw new NotImplementedException();
        }
    }
}
