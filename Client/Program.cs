using Greet;
using Grpc.Core;
using System;
using static Greet.GreetingService;

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
            Console.WriteLine(result.Response);
            Console.ReadLine();
        }
    }
}
