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
        private int _basketSize;

        public Basket(int size = 3)
        {
            _basketSize = size;
        }

        public bool AddProduct(string product)
        {
            if (_items.Count >= _basketSize)
            {
                return false;
            }
            _items.Add(product);
            return true;
        }

        public bool ChangeSize(int newSize)
        {
            if (newSize < 0 || newSize < _items.Count)
            {
                return false;
            }
            _basketSize = newSize;
            return true;
        }

        public bool RemoveProduct(string product)
        {
            return _items.Remove(product);
        }
    }
}
