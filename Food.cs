using System.Drawing;

namespace Snake
{
    public sealed class Food // Singleton Pattern
    {
        public static Food Instance { get; } = new Food();        
        public Point Position { get; set; }
        private Food() { }
    }
}
