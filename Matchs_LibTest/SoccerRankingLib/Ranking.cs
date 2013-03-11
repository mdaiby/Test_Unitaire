using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Matchs_Lib;
using PointSystemLib;

namespace SoccerRankingLib
{
    public class Ranking
    {
       
        public class RankingEntry : IComparable
        {
            private Clubs club;
            private PointSystem.ITotal point;

            public RankingEntry (Clubs club, PointSystem.ITotal point)
            {
                this.club = club;
                this.point = point;
            }
            public Clubs _club
            {
                get { return this.club; }
            }
            public PointSystem.ITotal _point
            {
                get { return this.point; }
            }
            public int CompareTo(Object obj)
            {
                return -this.point.CompareTo(((RankingEntry)obj).point);
            }
        }

        private RankingEntry[] entries;
        private PointSystem point_system;

        public Ranking(Clubs[] clubs, PointSystem _point)
        {
            this.entries = new RankingEntry[clubs.Length];
            this.point_system = _point;

        }
        public Ranking(Clubs[] clubs)
        {
            this.entries = new RankingEntry[clubs.Length];
            this.point_system = null;
        }
        public RankingEntry EntryFromClub(Clubs club)
        {
            foreach (RankingEntry entry in entries)
            
                if (entry._club == club)
                    return entry;
            return null;
            
        }
        public Clubs getClubs(int index)
        {
            return entries[index]._club;
        }
        public PointSystem.ITotal getPoint(Clubs club)
        {
            return EntryFromClub(club)._point;
        }
        public PointSystem.ITotal getPoint(int index)
        {
            return entries[index]._point;
        }
        public void register(Matchs m)
        {
            EntryFromClub(m.Home)._point.Increment(point_system.GetPointFromMatch(m, true));
            EntryFromClub(m.Away)._point.Increment(point_system.GetPointFromMatch(m, false));
            Array.Sort(entries);

        }
        
    }
}
