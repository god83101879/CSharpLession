using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trylifecircle
{
    public class Item
    {
        public static string GetItemValue()
        {
            return HttpContext.Current.Items["key1"] as string;
        }
    }
}