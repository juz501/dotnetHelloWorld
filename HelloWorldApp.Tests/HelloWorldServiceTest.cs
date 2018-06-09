using NUnit.Framework;
using HelloWorldApp;

namespace HellWorldApp.UnitTests.Services
{
    [TestFixture]
    public class HelloWorldApp_IsTextReturned
    {
        private readonly HelloWorldService _helloWorldService;
        
        public HelloWorldApp_IsTextReturned() {
            _helloWorldService = new HelloWorldService();
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ShouldReturnStringContainingHello()
        {
            var result = _helloWorldService.GetHelloWorld();
            StringAssert.Contains( "Hello", result );
        }

        [Test]
        public void ShouldReturnStringContainingWorld()
        {
            var result = _helloWorldService.GetHelloWorld();
            StringAssert.Contains( "World", result );
        }
    }
}