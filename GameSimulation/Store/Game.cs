using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Store
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ReviewScore { get; set; }
        public double Price { get; set; }
    }
}
