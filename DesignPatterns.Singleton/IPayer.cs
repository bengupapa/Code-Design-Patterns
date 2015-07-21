using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public interface IPayer
    {
        string PlayerName { get; }
        int NumberOfGamesPlayed { get; }
        decimal Remuneration { get;}

        int GetGamesPlayed();
        void SetRemuneration(decimal salary = 7000);
    }

    public class SoccerPlayer : IPayer
    {
        private decimal Salary;

        public string PlayerName
        {
            get { return "Papa Bengu"; }
        }

        public int NumberOfGamesPlayed
        {
            get { return 7; }
        }

        public int GetGamesPlayed()
        {
            return this.NumberOfGamesPlayed;
        }

        public void SetRemuneration(decimal salary = 23470)
        {
            this.Salary = salary;
        }

        public decimal Remuneration
        {
            get { return this.Salary; }
        }
    }

    public class TennisPlayer : IPayer
    {

        private decimal Salary;

        public string PlayerName
        {
            get { return "Madillo Bengu"; }
        }

        public int NumberOfGamesPlayed
        {
            get { return 10; }
        }

        public decimal Remuneration
        {
            get { return this.Salary; }
        }

        public int GetGamesPlayed()
        {
            return this.NumberOfGamesPlayed;
        }

        public void SetRemuneration(decimal salary = 67560)
        {
            this.Salary = salary;
        }
    }

    public class VolleyBallPlayer : IPayer
    {
        private decimal Salary;

        public string PlayerName
        {
            get { return "Dikeledi Ngqwemla"; }
        }

        public int NumberOfGamesPlayed
        {
            get { return 20; }
        }

        public decimal Remuneration
        {
            get { return this.Salary; }
        }

        public int GetGamesPlayed()
        {
            return NumberOfGamesPlayed;
        }

        public void SetRemuneration(decimal salary = 5600)
        {
            this.Salary = salary;
        }
    }
}
