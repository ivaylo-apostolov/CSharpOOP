using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class TestList : ITestList
    {
        private List<ITestList> list;

        public TestList()
        {
            this.list = new List<ITestList>();
        }

        public IReadOnlyCollection<ITestList> List
        {
            get
            {
                return this.list;
            }
        }

        public void Add(ITestList testList)
        {
            list.Add(testList);
        }
    }
}
