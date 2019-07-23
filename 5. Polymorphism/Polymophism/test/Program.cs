using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestList testList = new TestList();

            testList.Add(testList);

            int test = testList.List.Count;
        }
    }
}
