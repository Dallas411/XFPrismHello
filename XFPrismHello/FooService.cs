using System;
using System.Collections.Generic;
using System.Text;

namespace XFPrismHello
{
    public class FooService : IFooService
    {
        public string SayHello()
        {
            return "Hello Guys!";
        }
    }
}
