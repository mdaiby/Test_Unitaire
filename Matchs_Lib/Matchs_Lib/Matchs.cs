using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Matchs_Lib
{
    public class Matchs
    {
        private Clubs _away, _home;
        private int _awayGoal, _homeGoal;
        private bool  _isHomeForfeit;


        public Matchs(Clubs home, Clubs away, int homeGoal, int awayGoal)
        {
            this._away = away;
            this._home = home;
            this._homeGoal = homeGoal;
            this._awayGoal = awayGoal;
        }
        public Matchs(Clubs home, Clubs away, bool IsHomeForfeit)
        {
            this._home = home;
            this._away = away;
            this._isHomeForfeit = IsHomeForfeit;
        }
        public Matchs()
        {
            this._home = new Clubs("");
            this._away = new Clubs("");
            this._homeGoal = 0;
            this._awayGoal = 0;
        }

        public Clubs Away
        {
            get { return this._away; }

        }
        public int AwayGoal
        {
            get { return this._awayGoal; }
        }
        public Clubs Home
        {
            get { return this._home; }
        }
        public int HomeGoals
        {
            get { return this._homeGoal; }
        }
       
        public bool IsHomeForfeit
        {
            get
            {
                return this._isHomeForfeit;
            }
        }
        public bool IsAwayForfeit
        {
            get
            {
                if(this._isHomeForfeit == false)
                    return true;
                return false;
            }
        }
        public bool IsDraw
        {
            get
            {
                if (this._homeGoal == this._awayGoal)
                    return true;
                return false;
            }

        }
        public int getGoal(bool isHome)
        {
            if (!isHome)
                return this._awayGoal;
            return this._homeGoal;
        }
    } 

}
