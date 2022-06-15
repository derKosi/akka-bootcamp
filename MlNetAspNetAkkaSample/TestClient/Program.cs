// See https://aka.ms/new-console-template for more information
using RestSharp;

Console.WriteLine("Hello, World!");


var restClient = new RestClient("https://localhost:58469");

var restRequest = new RestRequest("api/Predict", Method.Post);

var irisData = new IrisData
{
    SepalLength = 3.3f,
    SepalWidth = 1.6f,
    PetalLength = 0.2f,
    PetalWidth = 5.1f
};

restRequest.AddJsonBody(irisData);

var result = restClient.Post(restRequest);

Console.WriteLine(result.Content);

Console.ReadKey();

public class IrisData
{
    public float SepalLength { get; set; }
    public float SepalWidth { get; set; }
    public float PetalLength { get; set; }
    public float PetalWidth { get; set; }
}
