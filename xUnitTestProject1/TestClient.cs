using asp_odata_api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace xUnitTestProject1
{
    public class TestClient
    {
        public HttpClient Client { get; set; }

        public TestClient()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>()
                .UseSetting("ConnectionStrings:SqlServer", "Server=WIN-401QH6I8IG7; Database=OData; Integrated Security=True")
            );

            Client = server.CreateClient();
        }
    }
}
