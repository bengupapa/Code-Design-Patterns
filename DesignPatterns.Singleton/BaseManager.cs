using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class BaseManager
    {
        private static BaseManager InitialInstance = null;
        public List<IPayer> Players;

        private BaseManager()
        {
            Players = new List<IPayer>()
            {
                new SoccerPlayer(),
                new TennisPlayer(),
                new VolleyBallPlayer(),
            };

            Players.ForEach(p => p.SetRemuneration());
        }

        public static BaseManager Instance
        {
            get
            {
                return InitialInstance ?? (InitialInstance = new BaseManager());
            }
        }

    }
}
