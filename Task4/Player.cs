using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Player
    {
        string playerName;
        int level;
        int health;
        public Player()
        {

            Console.WriteLine("Default Constructor has been called");
        }
        public Player(string name, int level, int health)
        {
            this.playerName = name;
            this.level = level;
            this.health = health;
        }
        public string PlayerName => playerName;
        public int Level => level;
        public int Health => health;

        public override string ToString()
        {
            return $"Name: {PlayerName ?? "null"}, Level: {Level}, Health: {Health}";
        }
    }

}
