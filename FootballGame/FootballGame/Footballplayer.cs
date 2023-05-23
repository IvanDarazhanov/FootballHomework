using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public abstract class Footballplayer:Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
    }
}
