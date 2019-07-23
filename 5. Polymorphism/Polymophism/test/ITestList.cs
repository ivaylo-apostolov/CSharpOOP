using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public interface ITestList
    {
        IReadOnlyCollection<ITestList> List { get; }

        void Add(ITestList testList);
    }
}
