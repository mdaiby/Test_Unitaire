using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matchs_Lib;
using System.Collections.Generic;

namespace Matchs_LibTest
{
    [TestClass]
    public class ClubsTest
    {
       
        [TestMethod]
        public void TestToString()
        {
            String nom = "Bordeaux";
            Clubs C1 = new Clubs(nom);
            Assert.AreEqual(nom, C1.ToString());

        }
    }
}
