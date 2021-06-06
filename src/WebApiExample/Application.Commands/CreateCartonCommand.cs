using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Application
{
    public record CreateCartonCommand : IRequest<CreateCartonStatus>
        , IBelongsToCarton
    {
        public string OrganizationId { get; init; }
        public string TenantId { get; init; }
        public string CartonId { get; init; }
    }

    public enum CreateCartonStatus
    {
        Ok,
        CartonAlreadyExists,
        UnknownError,
    }

    public partial class Handler
        : IRequestHandler<CreateCartonCommand, CreateCartonStatus>
        , IPipelineBehavior<CreateCartonCommand, CreateCartonStatus>
    {
        public async Task<CreateCartonStatus> Handle(CreateCartonCommand request, CancellationToken cancellationToken)
        {
            var insertCarton = new DataObjecs.InsertCarton
            {
                OrganizationId = request.OrganizationId,
                TenantId = request.TenantId,
                CartonId = request.CartonId,
            };

            await Writer.Write(insertCarton, cancellationToken);

            return CreateCartonStatus.Ok;
        }

        public async Task<CreateCartonStatus> Handle(CreateCartonCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<CreateCartonStatus> next)
        {
            try
            {
                var doesIt = new DataObjecs.DoesCartonExist
                {
                    OrganizationId = request.OrganizationId,
                    TenantId = request.TenantId,
                    CartonId = request.CartonId,
                };

                if (await Reader.Read(doesIt, cancellationToken))
                {
                    return CreateCartonStatus.CartonAlreadyExists;
                }
                else
                {
                    return await next();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to create carton");
                return CreateCartonStatus.UnknownError;
            }
        }
    }
}
