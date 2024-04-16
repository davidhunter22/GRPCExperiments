// The Greet namespace is the package name in the .proto file

public class GreeterService : Greet.Greeter.GreeterBase
{
    public override Task<Greet.HelloReply> SayHello( Greet.HelloRequest request, Grpc.Core.ServerCallContext context )
    {
        return Task.FromResult( new Greet.HelloReply
        {
            Message = "Hello " + request.Name
        } );
    }
}

