using System;

namespace Demo.WebAPI.MediatRPipeline.DTOs
{
    public class DemoRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}