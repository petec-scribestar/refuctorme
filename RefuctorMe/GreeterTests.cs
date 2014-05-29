namespace RefuctorMe
{
    using NUnit.Framework;

    [TestFixture]
    public class GreeterTests
    {
        [Test]
        public void SaysHello()
        {
            var greeting = new Greeter().Greet();
            Assert.That(greeting, Is.EqualTo("Hello"));
        }
    }
}