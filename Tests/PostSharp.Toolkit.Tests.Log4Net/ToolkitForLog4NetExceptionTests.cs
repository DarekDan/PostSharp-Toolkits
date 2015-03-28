using System;
using System.IO;
using log4net;
using log4net.Config;
using NUnit.Framework;
using TestAssembly;

namespace PostSharp.Toolkit.Tests.Log4Net
{
    [TestFixture]
    public class ToolkitForLog4NetExceptionTests : ConsoleTestsFixture
    {
        [TestCase(null, ExpectedException = typeof(Exception))]
        public void Log4Net_OnException_MustThrow(object none)
        {
            var logger = LogManager.GetLogger(typeof(ToolkitForLog4NetTests));
            Assert.IsFalse(logger.IsWarnEnabled);
            SimpleClass s = new SimpleClass();
            s.MethodThrowsException();
        }

        [TestFixtureSetUp]
        public void SetUp()
        {
            XmlConfigurator.Configure(new FileInfo("log4net.cfg"));
        }

        [TestFixtureTearDown]
        public void CleanUp()
        {
            LogManager.ResetConfiguration();
        }
    }
}