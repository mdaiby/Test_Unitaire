using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PointSystemLib;
using Matchs_Lib;
namespace TestRanking
{
    public class BasicPointSystemMock : PointSystem
    {
        public class TotalMock : ITotal
        {
            private int point;
            public TotalMock()
            {
                this.point = 0;
            }
            public TotalMock(Matchs m, bool IsHome)
            {
                this.point = m.HomeGoals - m.AwayGoal;
            }
            public void Increment(ITotal with)
            {
                this.point += ((TotalMock)with).point;
            }
            public int CompareTo(Object obj)
            {
                return this.point - ((TotalMock)obj).point;
            }
        }
        public  ITotal InitialPoint
        {
            get { return new TotalMock(); }
        }
        public override ITotal GetPointFromMatch(Matchs m, bool IsHome)
        {
            return new TotalMock(m, IsHome);
        }
    }
}
