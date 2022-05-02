using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWithDependencyInjection
{
    public class FooService : IFooService
    {
        public FooService(IConfiguration _configuration)
        {
            var we = _configuration.GetValue<string>("Op1");
        }
        public void GetFoo()
        {
            Console.WriteLine("GetFoo Called !!");
        }
    }
}
