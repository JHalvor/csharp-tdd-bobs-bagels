using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _items = new List<string>();
        public bool AddProduct(string product)
        {
            _items.Add(product);
            return true;
        }

        public bool RemoveProduct(string product)
        {
            return _items.Remove(product);
        }
    }
}
