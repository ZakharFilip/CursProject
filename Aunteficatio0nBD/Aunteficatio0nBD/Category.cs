using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aunteficatio0nBD
{
    internal class Category
    {
        private string _categoryName;
        private int _categoryId;
        public string CategoryName { get => _categoryName; }
        public int CategoryId { get => _categoryId; }
        public Category(string categoryName, int categoryId)
        {
            _categoryName = categoryName;
            _categoryId = categoryId;
        }
        public override string ToString()
        {
            return _categoryName;
        }
    }
}
