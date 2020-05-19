using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace Softplan.DesafioTecnico.UnitTests.Context
{
    public class TestsContext
    {
        public HttpClient FirstClient { get; set; }
        public HttpClient SecondClient { get; set; }
        private readonly TestServer _firstServer;
        private readonly TestServer _secondServer;

        public TestsContext()
        {
            _firstServer = new TestServer(new WebHostBuilder().UseStartup<FirstApi.Startup>());
            _secondServer = new TestServer(new WebHostBuilder().UseStartup<SecondApi.Startup>());

            FirstClient = _firstServer.CreateClient();
            SecondClient = _secondServer.CreateClient();
        }
    }
}
