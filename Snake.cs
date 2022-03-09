using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snake
{
    public enum SnakeDirection
    {
        Up, Right, Down, Left
    }

    public class Snake
    {
        private int score;
        private bool grow = false;
        public Point Position { get; set; }
        public int CellSize { get; set; } = GridWorld.cellSize;
        public List<Point> Body { get; } = new List<Point>();
        public SnakeDirection Direction { get; set; } = SnakeDirection.Right;
        public Snake(int xPos, int yPos)
        {
            Position = new Point(xPos, yPos);
        }

        public int Score
        {
            get
            {
                return score;
            }
        }

        public void Move()
        {
            if(grow == true)
            {
                Body.Add(new Point(Position.X, Position.Y));
            }

            for (var i = Body.Count - 1; i >= 1; i--)
            {
                Body[i] = Body[i - 1];
            }

            if (Body.Any())
            {
                Body[0] = new Point(Position.X, Position.Y);
            }


            switch (Direction)
            {
                case SnakeDirection.Right:
                    Position += new Size(CellSize, 0);
                    break;
                case SnakeDirection.Down:
                    Position += new Size(0, CellSize);
                    break;
                case SnakeDirection.Left:
                    Position += new Size(-CellSize, 0);
                    break;
                case SnakeDirection.Up:
                    Position += new Size(0, -CellSize);
                    break;
                default:
                    break;
            }

            grow = false;
            
        }

        public void Eat()
        {
            score++;
            grow = true;
        }

        public bool CheckCollision(Point p)
        {
            return (Position.Equals(p));
        }

        public bool CheckBodyCollision(Point p)
        {
            foreach (var part in Body)
            {
                if (part == p)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
