using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAdd
    {
        public List<string> AddCollect { get; set; }

        public string Add()
        {
            throw new NotImplementedException();
        }
    }
}
