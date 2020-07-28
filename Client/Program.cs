using Grpc.Core;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("localhost:5000", ChannelCredentials.Insecure);
            channel.ConnectAsync().ContinueWith((task) => { 
                if(task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("Connected to server..");
                }
            });
            Console.ReadLine();
        }
    }
}
