using System;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string Id { get; private set; }
        public Player(string name)
        {
            Name = name;
            Id = Guid.NewGuid().ToString();
        }
        public abstract Moves Play();

        public string Name { get; private set; }
    }
}
