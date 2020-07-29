using Grpc.Core;
using Primernumber;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Primernumber.PrimeNumberDecomposition;

namespace Server
{
    public class PrimeNumberDecompositionServiceImpl : PrimeNumberDecompositionBase
    {
        public override async Task GetPrimeNumberDecomposition(Request request, IServerStreamWriter<ResponseManyTimes> responseStream, ServerCallContext context)
        {
            int k = 2;
            int num = request.Number;
            while (num > 1)
            {
                if (num % k == 0)
                {
                    await responseStream.WriteAsync(new ResponseManyTimes { Result = k });
                    num = num / k;
                }
                else
                {
                    k += 1;
                }
            }
        }
    }
}
