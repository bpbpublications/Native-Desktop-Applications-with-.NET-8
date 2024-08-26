using Grpc.Net.Client;
using GrpcServiceDemo;
using static GrpcServiceDemo.Greeter;

namespace GrpcClientDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            GreeterClient greeterClient = new GreeterClient(channel);
            HelloReply helloReply = greeterClient.SayHello(new HelloRequest() { Name = "Sai" });
            Console.WriteLine("Given Name is " + helloReply.Message);
            Console.ReadKey();
        }
    }
}
