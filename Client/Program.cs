using Greet;
using Grpc.Core;
using Primernumber;
using System;
using static Greet.GreetingService;
using static Primernumber.PrimeNumberDecomposition;

namespace Client
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Channel channel = new Channel("localhost:5000", ChannelCredentials.Insecure);
            await channel.ConnectAsync().ContinueWith((task) => { 
                if(task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("Connected to server..");
                }
            });
            var client = new GreetingServiceClient(channel);
            var result = await client.GreetFuncAsync(new GreetingRequest { Request = new Greeting { Firstname = "Sanjeev", Lastname = "Baghel" } });
            var stream = client.GreetManyTimes(new GreetingManyTimesRequest { Request = new Greeting { Firstname = "Sanjeev", Lastname = "Baghel" } });
            while(await stream.ResponseStream.MoveNext())
            {
                Console.WriteLine(stream.ResponseStream.Current.Response);
            }
            Console.WriteLine(result.Response);
            var client2 = new PrimeNumberDecompositionClient (channel);
            var stream2 = client2.GetPrimeNumberDecomposition(new Request { Number = 120 });
            while(await stream2.ResponseStream.MoveNext())
            {
                Console.Write(stream2.ResponseStream.Current.Result+ " *");
            }
            Console.ReadLine();
        }
    }
}
