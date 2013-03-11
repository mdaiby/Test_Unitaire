using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PointSystemLib;
using Matchs_Lib;
using TestRanking;
using SoccerRankingLib;

namespace FrenchLeague1PointSystemLib
{
    public  class FrenchLeague1PointSystem : PointSystem
    {
        public class PointTotal : ITotal
        {
            private int goalaverage = 0;
            private int point;

            public PointTotal()
            {
                this.point = 0;
                //this.goalaverage += this.point;
            }
            public PointTotal(Matchs m, bool isHome)
            {
                this.point = m.HomeGoals - m.AwayGoal;
                this.goalaverage += this.point;
            }
            public void Increment(ITotal ipoint)
            {
                this.point += ((PointTotal)ipoint).point;
            }
            public int CompareTo(Object obj)
            {
                return this.point - ((PointTotal)obj).point;
            }
            public override string ToString()
            {
                return base.ToString();
            }
        }
        

        private static FrenchLeague1PointSystem theInstance = new FrenchLeague1PointSystem();
       
        public ITotal InitialPoint
        {
            get { return new PointTotal(); }
        }
        public static PointSystem Instance
        {
            get { return theInstance; }
        }
        public override ITotal GetPointFromMatch(Matchs m, bool IsHome)
        {
            return new PointTotal(m, IsHome);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
