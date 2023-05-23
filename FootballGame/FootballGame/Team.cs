using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Team
    {
        public Coach Coach { get; set; }
        //public List<Footballplayer> Players(int numplayers)
        //{
        //    if (numplayers < 11 || numplayers > 22)
        //    {
        //        throw new Exception();
        //    }
        //    else
        //    {
        //        return new List<Footballplayer>();
        //    }
        //}
        public List<Footballplayer> Players { get; set; }
        public double AverageAge()
        {
            double sumage =Players.Sum(player=>player.Age);
            double avg = sumage / Players.Count;
            return avg;
        } 
    }
}
