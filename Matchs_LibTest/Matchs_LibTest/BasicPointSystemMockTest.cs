using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointSystemLib;
using Matchs_Lib;
using TestRanking;
namespace Matchs_LibTest
{
    [TestClass]
    public class BasicPointSystemMockTest
    {
        [TestMethod]
        public void TestBasicPointSystemMockInitialPoint()
        {
           BasicPointSystemMock BPS = new BasicPointSystemMock();
           BasicPointSystemMock.ITotal IT = BPS.InitialPoint;
           Assert.AreEqual(0, BPS.InitialPoint.CompareTo(IT));
        }
    }
}
