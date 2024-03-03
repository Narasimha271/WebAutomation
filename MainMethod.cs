using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    public class MainMethod
    {
       
        static void Main(string[] args)
        {
            Ebay obj = new Ebay();
            obj.Navigate_to_Ebay();
            obj.SearchOnAmazon();
            obj.findingElementsOnAmazon();
            //obj.closeBrowser();
        }
    }
}
