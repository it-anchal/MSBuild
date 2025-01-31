using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace UnitTesting;

[TestClass]
public class UnitTest1
{
    private const string Expected = "Hello World! ";

    [TestMethod]
    public void TestMethod1()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            JenkinsJobDotnet.Program.Main();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
        }

    }
}
