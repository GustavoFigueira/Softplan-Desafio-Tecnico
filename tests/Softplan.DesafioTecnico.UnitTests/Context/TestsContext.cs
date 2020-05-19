using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace Softplan.DesafioTecnico.UnitTests.Context
{
    public class TestsContext
    {
        public HttpClient Client { get; set; }
        private readonly TestServer _server;

        public TestsContext()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Softplan.DesafioTecnico.FirstApi.Startup>());
            Client = _server.CreateClient();
        }
    }
}
