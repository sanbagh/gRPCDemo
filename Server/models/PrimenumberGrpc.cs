// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: primenumber.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Primernumber {
  public static partial class PrimeNumberDecomposition
  {
    static readonly string __ServiceName = "primernumber.PrimeNumberDecomposition";

    static readonly grpc::Marshaller<global::Primernumber.Request> __Marshaller_primernumber_Request = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Primernumber.Request.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Primernumber.ResponseManyTimes> __Marshaller_primernumber_ResponseManyTimes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Primernumber.ResponseManyTimes.Parser.ParseFrom);

    static readonly grpc::Method<global::Primernumber.Request, global::Primernumber.ResponseManyTimes> __Method_GetPrimeNumberDecomposition = new grpc::Method<global::Primernumber.Request, global::Primernumber.ResponseManyTimes>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetPrimeNumberDecomposition",
        __Marshaller_primernumber_Request,
        __Marshaller_primernumber_ResponseManyTimes);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Primernumber.PrimenumberReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PrimeNumberDecomposition</summary>
    [grpc::BindServiceMethod(typeof(PrimeNumberDecomposition), "BindService")]
    public abstract partial class PrimeNumberDecompositionBase
    {
      public virtual global::System.Threading.Tasks.Task GetPrimeNumberDecomposition(global::Primernumber.Request request, grpc::IServerStreamWriter<global::Primernumber.ResponseManyTimes> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PrimeNumberDecomposition</summary>
    public partial class PrimeNumberDecompositionClient : grpc::ClientBase<PrimeNumberDecompositionClient>
    {
      /// <summary>Creates a new client for PrimeNumberDecomposition</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PrimeNumberDecompositionClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PrimeNumberDecomposition that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PrimeNumberDecompositionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PrimeNumberDecompositionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PrimeNumberDecompositionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Primernumber.ResponseManyTimes> GetPrimeNumberDecomposition(global::Primernumber.Request request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPrimeNumberDecomposition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Primernumber.ResponseManyTimes> GetPrimeNumberDecomposition(global::Primernumber.Request request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetPrimeNumberDecomposition, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PrimeNumberDecompositionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PrimeNumberDecompositionClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PrimeNumberDecompositionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetPrimeNumberDecomposition, serviceImpl.GetPrimeNumberDecomposition).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PrimeNumberDecompositionBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetPrimeNumberDecomposition, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Primernumber.Request, global::Primernumber.ResponseManyTimes>(serviceImpl.GetPrimeNumberDecomposition));
    }

  }
}
#endregion
