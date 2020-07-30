using System;
using System.Collections.Generic;
using System.IO;
using Greet;
using Grpc.Core;
using Grpc.Reflection;
using Grpc.Reflection.V1Alpha;
using Primernumber;
using Squre;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var serverCert = File.ReadAllText("../../../ssl/server.crt");
            var serverKey = File.ReadAllText("../../../ssl/server.key");
            var caCert = File.ReadAllText("../../../ssl/ca.crt");
            var channelCredential = new SslServerCredentials(new List<KeyCertificatePair> { new KeyCertificatePair(serverCert, serverKey) }, caCert, true);
            var serviceDesc = new ReflectionServiceImpl(GreetingService.Descriptor, ServerReflection.Descriptor);
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { GreetingService.BindService(new GreetingServiceImpl()),
                    PrimeNumberDecomposition.BindService(new PrimeNumberDecompositionServiceImpl()),
                    SquareRootService.BindService(new SquareRootServiceImpl()),
                ServerReflection.BindService(serviceDesc)},
                //Ports = { new ServerPort("localhost", 5000, ServerCredentials.Insecure) }
                Ports = { new ServerPort("localhost", 5000, channelCredential) }
            };
            server.Start();
            Console.WriteLine("server started...");
            Console.ReadLine();
        }
    }
}
