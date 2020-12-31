using ExtensionMethods.Library;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Linq;

namespace ExtensionMethods.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsLoaded()
        {
            IConfiguration config = null;
            Assert.IsFalse(config.IsLoaded());
        }

        [Test]
        public void AddStandardProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProviders().Build();
            Assert.AreEqual(4, config.Providers.Count());
            Assert.IsTrue(config.IsLoaded());
        }
    }
}