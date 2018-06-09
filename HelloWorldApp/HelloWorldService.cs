using System;

namespace HelloWorldApp
{
    public class HelloWorldService
    {
        public string GetHelloWorld() {
          return "Hello World!";
        }

        static void Main(string[] args)
        {
            HelloWorldService hws = new HelloWorldService();
            Console.WriteLine( hws.GetHelloWorld() );
        }
    }
}
