using NUnit.Framework;
using HelloWorld;

namespace HelloWorldTests
{
    using System;

    [TestFixture]
    public class TestHelloWorld
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Console.WriteLine("Starting TestHelloWorld tests");
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Console.WriteLine("TestHelloWorld tests are finished");
        }


        [Category("SumTests")]
        [Test]
        public void Test1()
        {
            Assert.That(Calculator.Sum(5, 5), Is.EqualTo(10));
        }

        [Category("SumTests")]
        [Test]
        public void Test2()
        {
            Assert.That(Calculator.Sum(-5, -5), Is.EqualTo(-10));
        }

        [Category("SubstractTests")]
        [Test]
        public void Test3()
        {
            Assert.That(Calculator.Substract(5, 5), Is.EqualTo(0));
        }

        [Category("SubstractTests")]
        [Test]
        public void Test4()
        {
            Assert.That(Calculator.Substract(-5, -5), Is.EqualTo(0));
        }     
        
        [Category("SubstractTests")]
        [Test]
        public void Test5()
        {
            Assert.That(Calculator.Substract(0, 100), Is.EqualTo(-100));
        }

        [Category("SubstractTests")]
        [Test]
        public void Test6()
        {
            Assert.That(Calculator.Substract(0, -100), Is.EqualTo(99));
        }
        
        [Ignore("Ignoring")]
        [Category("SubstractTests")]
        [Test]
        public void Test7()
        {
            Assert.That(Calculator.Substract(0, -100), Is.EqualTo(99));
        }         
    }
}
