using Grpc.Core;
using Squre;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Squre.SquareRootService;

namespace Server
{
    public class SquareRootServiceImpl: SquareRootServiceBase
    {
        public override async Task<Response> CalculateSquare(Request request, ServerCallContext context)
        {
            var number = request.Number;
            if (number >= 0)
                return await Task.FromResult(new Response { Sqrt = number * number });
            else
                throw new RpcException(new Status(StatusCode.InvalidArgument, "number < 0"));
        }
    }
}
