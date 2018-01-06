using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using isRock.Framework;
using isRock.Framework.WebAPI;

namespace testWebSite.Controllers
{
    public class ExampleController : ApiController
    {
        [Route("api/Example/{MethodName}")]
        [HttpPost]
        public IHttpActionResult ExecuteMethod(string MethodName)
        {
            try
            {
                //AssemblyLauncher
                AssemblyLauncher assemblyLauncher = new AssemblyLauncher();
                //執行指定的Method
                var ret = assemblyLauncher.ExecuteCommand<BO.TestClassA>(
                    new BO.TestClassA(),
                    MethodName,
                    Request.Content.ReadAsStringAsync().Result);
                //回傳OK
                return Ok(ret);
            }
            catch (Exception ex)
            {
                //其他處理
                throw ex;
            }
        }
    }

	
}
