using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_odata_api.Controllers
{
    
    public class CustomersController : ODataController
    {
        private readonly QueryFactory _queryFactory;
        private readonly ILogger<CustomersController> _logger;
        
        public CustomersController(QueryFactory queryFactory, ILogger<CustomersController> logger)
        {
            _queryFactory = queryFactory;
            _logger = logger;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            var result = _queryFactory.Query("Customers").Select("Name", "Country", "City").Get();
            return Ok(result);
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            var result = _queryFactory.Query("Customers").Where("Id", key).Get();
            return Ok(result);
        }
    }
}
