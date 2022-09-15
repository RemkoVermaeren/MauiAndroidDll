using CalculatorService;

namespace MauiAndroidDll.Proxy
{
    public class CalculatorClient
    {
        public async Task<int> AddAsync(int a, int b)
        {
            var serviceClient = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);
            var result = await serviceClient.AddAsync(a, b);

            return result;
        }
    }
}