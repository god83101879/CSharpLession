using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebForm
{
    public class Parent
    {
        public string Property1 { get; set; }
        public string Method1()
        {
            return string.Empty;
        }
    }

    public class Child : Parent
    {
        public int Property2 { get; set; }
    }
}