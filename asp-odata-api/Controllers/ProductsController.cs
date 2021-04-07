using asp_odata_api.Models;
using asp_odata_api.Services;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_odata_api.Controllers
{

    public class ProductsController : ODataController
    {
        private readonly ApplicationContext _context;

        public ProductsController(ApplicationContext context)
        {
            _context = context;
        }


        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(_context.Products.ToList());
        }

        [EnableQuery]
        public ActionResult Get(int key)
        {
            return Ok(_context.Products.Find(key));
        }

    }
}
