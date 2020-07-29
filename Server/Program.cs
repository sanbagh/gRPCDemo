﻿using System;
using System.Collections.Generic;
using Greet;
using Grpc.Core;
namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Grpc.Core.Server server = new Grpc.Core.Server {
                Services = { GreetingService.BindService(new GreetingServiceImpl()) },
                Ports = { new ServerPort("localhost", 5000, ServerCredentials.Insecure) } };
            server.Start();
            Console.WriteLine("server started...");
            Console.ReadLine();
        }
    }
}
