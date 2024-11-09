using System.Collections.Generic;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public string Name { get; set; }
        public abstract void Play();
    }
}
