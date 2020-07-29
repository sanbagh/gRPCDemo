using Greet;
using Grpc.Core;
using Primernumber;
using Squre;
using System;
using System.Linq;
using static Greet.GreetingService;
using static Primernumber.PrimeNumberDecomposition;
using static Squre.SquareRootService;

namespace Client
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Channel channel = new Channel("localhost:5000", ChannelCredentials.Insecure);
            await channel.ConnectAsync().ContinueWith((task) =>
            {
                if (task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("Connected to server..");
                }
            });
            var client = new GreetingServiceClient(channel);
            var result = await client.GreetFuncAsync(new GreetingRequest { Request = new Greeting { Firstname = "Sanjeev", Lastname = "Baghel" } });
            var stream = client.GreetManyTimes(new GreetingManyTimesRequest { Request = new Greeting { Firstname = "Sanjeev", Lastname = "Baghel" } });
            while (await stream.ResponseStream.MoveNext())
            {
                Console.WriteLine(stream.ResponseStream.Current.Response);
            }
            Console.WriteLine(result.Response);
            var client2 = new PrimeNumberDecompositionClient(channel);
            var stream2 = client2.GetPrimeNumberDecomposition(new Primernumber.Request { Number = 120 });
            while (await stream2.ResponseStream.MoveNext())
            {
                Console.Write(stream2.ResponseStream.Current.Result + " *");
            }

            var stream3 = client.GreetLong();
            foreach (int i in Enumerable.Range(1, 10))
            {
                var request = new GreetingLongRequest { Request = new Greeting { Firstname = "Sanjeev", Lastname = "Baghel " + i } };
                await stream3.RequestStream.WriteAsync(request);
            }
            await stream3.RequestStream.CompleteAsync();
            var streamResult = await stream3.ResponseAsync;
            Console.WriteLine(streamResult.Response);

            //sqrt
            var sqrtClient = new SquareRootServiceClient(channel);
            try
            {
                var sqrt = await sqrtClient.CalculateSquareAsync(new Squre.Request { Number = -1 });
                Console.WriteLine(sqrt.Sqrt);
            }
            catch (RpcException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var stream4 = client.GreetEveryone();
            foreach (int i in Enumerable.Range(1, 5))
            {
                await stream4.RequestStream.WriteAsync(new GreetingEveryoneRequest { Request = new Greeting { Firstname = "Sanjeev", Lastname = "baghel" } });
            }
            while (await stream4.ResponseStream.MoveNext())
            {
                Console.Write(stream4.ResponseStream.Current.Response);
            }
            await stream4.RequestStream.CompleteAsync();

           
            Console.ReadLine();
        }
    }
}
