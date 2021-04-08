using System;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace xUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public async void GetTest()
        {
            var client = new TestClient().Client;

            var ok = await client.GetAsync("odata/products(1)");
            ok.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, ok.StatusCode);
        }

        [Fact]
        public async void GetInvalidTest()
        {
            var client = new TestClient().Client;

            var ok = await client.GetAsync("odata/products(0)");
            ok.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, ok.StatusCode);
        }
    }
}
