using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> items = new List<string>();
        public bool AddProduct(string product)
        {
            items.Add(product);
            return true;
        }

        public bool RemoveProduct()
        {
            return false;
        }
    }
}
