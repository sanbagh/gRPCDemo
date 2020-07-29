using Greet;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Greet.GreetingService;

namespace Server
{
    public class GreetingServiceImpl: GreetingServiceBase
    {
        public override Task<GreetingResponse> GreetFunc(GreetingRequest request, ServerCallContext context)
        {
            return Task.FromResult(new GreetingResponse { Response = $"Hello {request.Request.Firstname} {request.Request.Lastname}" });
        }
    }
}
