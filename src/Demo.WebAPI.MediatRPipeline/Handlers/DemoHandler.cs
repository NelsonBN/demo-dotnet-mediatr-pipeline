using Demo.WebAPI.MediatRPipeline.Commands;
using Demo.WebAPI.MediatRPipeline.DTOs;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.WebAPI.MediatRPipeline.Handlers
{
    public class DemoHandler : IRequestHandler<DemoCommand, DemoResponse>
    {
        private readonly ILogger<DemoHandler> _logger;

        public DemoHandler(
            ILogger<DemoHandler> logger
        )
        {
            this._logger = logger;
        }

        public Task<DemoResponse> Handle(DemoCommand command, CancellationToken cancellationToken)
        {
            this._logger.LogInformation("Start running handler...");

            var result = new DemoResponse
            {
                Id = command.Id,
                FullName = command.FirstName + " " + command.LastName
            };

            this._logger.LogInformation("Handler runned...");

            return Task.FromResult(result);
        }
    }
}