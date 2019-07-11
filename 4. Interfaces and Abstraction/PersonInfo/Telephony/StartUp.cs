using System;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split();

            foreach (var number in inputNumbers)
            {
                ICallable smartPhone = new Smartphone();

                Console.WriteLine(smartPhone.Calling(number));
            }

            var inputWebsites = Console.ReadLine()
                .Split();

            foreach(var webSites in inputWebsites)
            {
                IBrowsable smarthPhone = new Smartphone();

                Console.WriteLine(smarthPhone.Browsing(webSites));
            }
        }
    }
}
