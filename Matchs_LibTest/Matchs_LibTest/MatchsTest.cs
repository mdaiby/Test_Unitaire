using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matchs_Lib;
using FrenchLeague1PointSystemLib;
using PointSystemLib;
namespace Matchs_LibTest
{
    [TestClass]
    public class MatchsTest
    {
        public Clubs home = new Clubs("Bordeaux");
        public Clubs away = new Clubs("Lille");
        

        [TestMethod]
        public void TestAways()
        {
            Matchs matchs = new Matchs(home, away, 3, 2);
            Assert.AreEqual(2, matchs.AwayGoal);
            Assert.AreEqual(away, matchs.Away);
        }

        [TestMethod]
        public void TestHome()
        {
            Matchs matchs = new Matchs(home, away, 3, 3);
            Assert.AreEqual(3, matchs.AwayGoal);
            Assert.AreEqual(home, matchs.Home);
        }
        [TestMethod]
        public void TestHomeGoal()
        {
            Matchs matchs = new Matchs(home, away, 3, 3);
            Assert.AreEqual(3, matchs.HomeGoals);
            Assert.AreEqual(3, matchs.AwayGoal);

        }
        [TestMethod]
        public void TestAwayGoal()
        {
            
            Matchs matchs =  new Matchs(home, away, 3, 4);
            Assert.AreEqual(4, matchs.AwayGoal);
            Assert.AreEqual(3, matchs.HomeGoals);
        }
        [TestMethod]
        public void TestIsDraw()
        {
            Matchs matchs = new Matchs(home, away, 3,3);
            Assert.IsTrue(matchs.IsDraw);
        }
        [TestMethod]
        public void TestIsHomeForfeit()
        {
            Matchs matchs = new Matchs(home, away, true);
            Assert.IsTrue(matchs.IsHomeForfeit);
        }
        

        [TestMethod]
        public void TestIsAwayForfeit()
        {
            Matchs matchs = new Matchs(home, away, false);
            Assert.IsTrue(matchs.IsAwayForfeit);
        }


        
    }
}
