using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointSystemLib;
using FrenchLeague1PointSystemLib;
using Matchs_Lib;
using SoccerRankingLib;
namespace Matchs_LibTest
{
    [TestClass]
    public class RankingTest
    {
        [TestMethod]
        public void TestEntryFromCklub()
        {            
            Ranking Rk = new Ranking(new Clubs[10]);
           
        }

    }
}
