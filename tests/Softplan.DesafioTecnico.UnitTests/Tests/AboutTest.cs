using FluentAssertions;
using Softplan.DesafioTecnico.UnitTests.Context;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.DesafioTecnico.UnitTests.Tests
{
    public class AboutTest
    {
        private TestsContext _testsContext;

        public AboutTest()
        {
            _testsContext = new TestsContext();
        }

        [Fact]
        public async Task InterestRate_Should_ReturnDefaultValue()
        {
            //var dbContext = GetDbContext();
            //dbContext.Customers.Add(new Customer { Id = 1, Name = "Company 1" });
            //dbContext.Customers.Add(new Customer { Id = 2, Name = "Company 2" });
            //await dbContext.SaveChangesAsync();

            //var service = new CustomerService(dbContext);
            //var result = await service.List();

            //Assert.NotNull(result);
            //Assert.Equal(2, result.Count);
        }

        [Fact]
        public async Task TestaFuncionamento()
        {
            var response = await _testsContext.Client.GetAsync("/ShowMeTheCode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TestaChamadaErrada()
        {
            var response = await _testsContext.Client.GetAsync("/ChouMeTheCode");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task TestaTipoRetorno()
        {
            var response = await _testsContext.Client.GetAsync("ShowMeTheCode");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }

        [Fact]
        public async Task TestaFuncionamentoChamadaLetrasMinusculas()
        {
            var response = await _testsContext.Client.GetAsync("/showmethecode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
