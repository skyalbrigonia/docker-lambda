// Compile with:
// docker run --rm -v "$PWD":/var/task lambci/lambda:build-dotnetcore2.0 dotnet publish -c Release -o pub

// Run with:
// docker run --rm -v "$PWD"/pub:/var/task lambci/lambda:dotnetcore2.0 test::test.Function::FunctionHandler "some"

using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace test
{
    public class Function
    {
        public string FunctionHandler(object inputEvent, ILambdaContext context)
        {
            context.Logger.Log($"inputEvent: {inputEvent}");
            return "Hello World!";
        }
    }
}
