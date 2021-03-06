using System;
using Apache.Geode.NetCore;
using NUnit.Framework;

namespace GemfireDotNetTest
{
    public class CacheFactoryUnitTests 
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateFactory()
        {
            using (var client = new Client())
            {
                using (var cacheFactory = CacheFactory.Create())
                {
                    Assert.IsNotNull(cacheFactory);
                }
            }
        }
        
        [Test]
        public void TestCacheFactoryGetVersion()
        {
            using (var client = new Client())
            {
                using (var cacheFactory = CacheFactory.Create())
                {
                    var version = cacheFactory.Version;
                    Assert.AreNotEqual(version, String.Empty);
                }

                Assert.Pass();
            }
        }
        
        [Test]
        public void TestCacheFactoryGetProductDescription()
        {
            using (var client = new Client())
            {
                using (var cacheFactory = CacheFactory.Create())
                {
                    var description = cacheFactory.ProductDescription;
                    Assert.AreNotEqual(description, String.Empty);
                }

                Assert.Pass();
            }
        }
        
        [Test]
        public void TestCacheFactorySetPdxIgnoreUnreadFields()
        {
            using (var client = new Client())
            {
                using (var cacheFactory = CacheFactory.Create())
                {
                    cacheFactory.PdxIgnoreUnreadFields = true;
                    cacheFactory.PdxIgnoreUnreadFields = false;
                }

                Assert.Pass();
            }
        }
        
        [Test]
        public void TestCacheFactorySetPdxReadSerialized()
        {
            using (var client = new Client())
            {
                using (var cacheFactory = CacheFactory.Create())
                {
                    cacheFactory.PdxReadSerialized = true;
                    cacheFactory.PdxReadSerialized = false;
                }

                Assert.Pass();
            }
        }
        
        [Test]
        public void TestCacheFactoryCreateCache()
        {
            using (var client = new Client())
            {
                using (var cacheFactory = CacheFactory.Create())
                {
                    using (var cache = cacheFactory.CreateCache())
                    {
                        ;
                    }
                }

                Assert.Pass();
            }
        }
        
        [Test]
        public void TestCacheFactorySetProperty()
        {
            using (var client = new Client())
            {
                using (var cacheFactory = CacheFactory.Create())
                {
                    cacheFactory.SetProperty("log-level", "none")
                        .SetProperty("log-file", "geode_native.log");
                }

                Assert.Pass();
            }
        }
    }
}