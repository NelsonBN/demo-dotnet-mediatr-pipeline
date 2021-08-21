using Demo.WebAPI.MediatRPipeline.Commands;
using Demo.WebAPI.MediatRPipeline.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Demo.WebAPI.MediatRPipeline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;
        private readonly IMediator _mediator;

        public DemoController(
            ILogger<DemoController> logger,
            IMediator mediator
        )
        {
            this._logger = logger;
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(DemoRequest request)
        {
            var command = new DemoCommand(
                id: request.Id,
                firstName: request.FirstName,
                lastName: request.LastName
            );

            var result = await this._mediator.Send(command);

            return this.Ok(result);
        }
    }
}