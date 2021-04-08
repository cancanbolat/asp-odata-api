using asp_odata_api.Models;
using asp_odata_api.Services;
using Dapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_odata_api.Controllers
{
    public class CategoriesController : ODataController
    {
        private readonly IConfiguration _configuration;
        private string connString;
        IEnumerable<Category> categories = new List<Category>();

        public CategoriesController(IConfiguration configuration)
        {
            _configuration = configuration;
            connString = _configuration.GetConnectionString("SqlServer");
        }


        [EnableQuery]
        public ActionResult<IEnumerable<Category>> Get()
        {
            using (var con = new SqlConnection(connString))
            {
                con.Open();
                categories = con.Query<Category>("SELECT * FROM Categories");
            }
            return Ok(categories);
            //new ActionResult<IEnumerable<Category>>(categories);
        }


        [EnableQuery]
        public ActionResult<IEnumerable<Category>> Get(int key)
        {
            using (var con = new SqlConnection(connString))
            {
                con.Open();
                categories = con.Query<Category>("SELECT * FROM Categories WHERE Id = @Id", new { Id = key });
            }
            return Ok(categories);
        }
    }
}
