using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PoC.Cap.Infrastucture;
using System;
namespace PoC.Cap.Publisher.Controllers
{

    public class PublishController : Controller
    {
        private readonly ICapPublisher _capBus;

        public PublishController(ICapPublisher capPublisher)
        {
            _capBus = capPublisher;
        }

        [Route("publish")]
        [HttpGet()]
        public IActionResult AdonetWithTransaction()
        {
            var connectionString = @"YOUR_CONNECTION_STRING";
            using (var connection = new SqlConnection(connectionString))
            {
                using var transaction = connection.BeginTransaction(_capBus, autoCommit: true);
                //your business logic code
                var payload = new
                {
                    Id = Guid.NewGuid(),
                    Number = "random number",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = Guid.NewGuid()
                };
                _capBus.Publish(EventBusKey.EventCreated, payload);
            }

            return Ok();
        }
    }
}