using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityPackageTemplate.Tests
{

    public class MathHelpersTest
    {

        [Test]
        public void AddTwoNumbers()
        {


            Assert.AreEqual(3, MathHelpers.AddTwoNumbers(1, 2));

        }

    }

}
