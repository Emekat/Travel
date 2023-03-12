using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Travel.Application.Common.Behaviours
{
    //https://github.com/PacktPublishing/ASP.NET-Core-and-Vue.js/blob/master/Chapter07/Travel/src/core/Travel.Application/Common/Behaviors/LoggingBehavior.cs
    public class LoggingBehavior<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger _logger;

        public LoggingBehavior(ILogger<TRequest> logger)
        {
            _logger = logger;
        }

        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;
            _logger.LogInformation("Travel Request: {@Request}", requestName, request);
        }
    }
}
