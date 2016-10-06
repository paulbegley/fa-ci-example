#load "..\TimerTriggerCSharp1\HelloWorld.csx"

using System;
using System.Linq;
using System.Net;
using System.Xml;
//using NUnit.Core;

[TestFixture]
public class HelloFixture
{


    [Test]
    public void TestHelloWorld()
    {
        var greet = Hello.greet();

        Assert.AreEqual(greet, "Hello!", "The greeting is incorrect");
    }


}
