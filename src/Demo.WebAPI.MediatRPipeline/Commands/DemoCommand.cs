using Demo.WebAPI.MediatRPipeline.DTOs;
using MediatR;
using System;

namespace Demo.WebAPI.MediatRPipeline.Commands
{
    public record DemoCommand : IRequest<DemoResponse>
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public DemoCommand(Guid id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}