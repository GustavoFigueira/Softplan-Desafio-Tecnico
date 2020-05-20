using FluentAssertions;
using Microsoft.Extensions.Options;
using Softplan.DesafioTecnico.SecondApi.Models;
using Softplan.DesafioTecnico.IntegrationTests.Context;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.DesafioTecnico.IntegrationTests.Tests
{
    public class AboutTest
    {
        private readonly TestsContext _testsContext;

        public AboutTest()
        {
            _testsContext = new TestsContext();
        }

        [Fact]
        public async Task Test_Working()
        {
            var response = await _testsContext.Client.GetAsync("/ShowMeTheCode");
            response.EnsureSuccessStatusCode();
            Assert.Equal("text/html; charset=utf-8",
            response.Content.Headers.ContentType.ToString());
            //response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Test_WrongCall()
        {
            var response = await _testsContext.Client.GetAsync("/ChouMeTheCode");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
