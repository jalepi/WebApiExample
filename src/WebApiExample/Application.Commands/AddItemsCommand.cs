using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Application
{

    public record AddItemsCommand : IRequest<AddItemsStatus>
        , IBelongsToOrganization
        , IBelongsToTenant
    {
        public string OrganizationId { get; init; }
        public string TenantId { get; init; }
        public string CartonId { get; init; }
        public IReadOnlyCollection<string> Items { get; init; }
    }

    public enum AddItemsStatus
    {
        Ok,
        CartonNotFound,
        Unknown,
    }

    public partial class Handler
        : IRequestHandler<AddItemsCommand, AddItemsStatus>
        , IPipelineBehavior<AddItemsCommand, AddItemsStatus>
    {
        public async Task<AddItemsStatus> Handle(AddItemsCommand request, CancellationToken cancellationToken)
        {
            var doesCartonExist = new DataObjecs.DoesCartonExist { };

            if (await Reader.Read(doesCartonExist, cancellationToken))
            {
                return AddItemsStatus.CartonNotFound;
            }

            var insertItems = new DataObjecs.InsertItems
            {
                OrganizationId = request.OrganizationId,
                TenantId = request.TenantId,
                CartonId = request.CartonId,
                Items = request.Items.Select(item => new DataObjecs.InsertItems.Item
                {
                    ItemId = item,
                    ProductId = "(unknown)",
                }).ToArray(),
            };

            await Writer.Write(insertItems, cancellationToken);

            return AddItemsStatus.Ok;
        }

        public async Task<AddItemsStatus> Handle(AddItemsCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<AddItemsStatus> next)
        {
            try
            {
                var doesCartonExist = new DataObjecs.DoesCartonExist { };

                if (await Reader.Read(doesCartonExist, cancellationToken))
                {
                    return AddItemsStatus.CartonNotFound;
                }

                return await next();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to add items");
                return AddItemsStatus.Unknown;
            }
        }
    }
}
