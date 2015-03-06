using System;

namespace Lab1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            string msg = MessageProvider.Provider.GetMessage();

            msg = System.Web.HttpUtility.UrlEncode(msg);

            Console.WriteLine(msg);
            Console.ReadLine();

        }
    }
}
