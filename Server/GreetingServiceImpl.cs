﻿using Greet;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public override async Task GreetManyTimes(GreetingManyTimesRequest request, IServerStreamWriter<GreetingManyTimesResponse> responseStream, ServerCallContext context)
        {
            foreach(int val  in Enumerable.Range(1, 10))
            {
                await responseStream.WriteAsync(new GreetingManyTimesResponse { Response = $"Hello {request.Request.Firstname} {request.Request.Lastname}" });
            }
        }
        public override async Task<GreetingLongResponse> GreetLong(IAsyncStreamReader<GreetingLongRequest> requestStream, ServerCallContext context)
        {
            string result = string.Empty;
            while (await requestStream.MoveNext())
            {
                result +=requestStream.Current.Request.Firstname + " " + requestStream.Current.Request.Lastname + " ";
            }
            return new GreetingLongResponse { Response = result };
        }
        public override async Task GreetEveryone(IAsyncStreamReader<GreetingEveryoneRequest> requestStream, IServerStreamWriter<GreetingEveryoneResponse> responseStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext())
            {
                Console.WriteLine(requestStream.Current.Request.Firstname + " " + requestStream.Current.Request.Lastname + " ");
                await responseStream.WriteAsync(new GreetingEveryoneResponse { Response = "Hello from server" });
            }
        }
    }
}
