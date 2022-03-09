using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Snake
{
    /// <summary>
    /// - Grid Abstraktion
    /// </summary>
    public partial class Game : Form
    {
        private static Random rnd = new Random();
        private static int CellSize { get; set; } = GridWorld.cellSize;
        private static int gridWidth = GridWorld.gridWidth;
        private static int gridHeight = GridWorld.gridHeight;
        private static int speed = GridWorld.speed;
        private static bool gameHasStarted = false;
        private Size gridSize = new Size(gridWidth * CellSize, gridHeight * CellSize + 20);

        private Snake snake = new Snake(10, 10);

        public Game()
        {
            InitializeComponent();
            gameTimer.Interval = 100 * speed;
            canvas.Size = gridSize;
            canvas.Location = new Point(gridWidth / 2, gridHeight / 2 + 20);
            // Window Size
            Size = new Size(gridWidth * CellSize + 50, gridHeight * CellSize + 100);
            labelScore.Location = new Point(gridWidth / 2 * CellSize, 10);

            gameHasStarted = true;

            snake.Direction = SnakeDirection.Right;
            SpawnFood();
        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (gameHasStarted)
            {
                snake.Move();
                if (snake.CheckBodyCollision(snake.Position))
                {
                    LoseGame();
                }
                CheckWalls(snake);

                if (snake.CheckCollision(Food.Instance.Position))
                {
                    snake.Eat();
                    SpawnFood();
                    labelScore.Text = $"Score: {snake.Score}";
                }

                Refresh();
            }
        }

        private void SpawnFood()
        {
            do
            {
                Food food = Food.Instance; //Struct = reference only
                food.Position = new Point(rnd.Next(0, gridWidth) * CellSize, rnd.Next(0, gridHeight) * CellSize);
                while (snake.CheckBodyCollision(food.Position))
                {
                    food.Position = new Point(rnd.Next(0, gridWidth) * CellSize, rnd.Next(0, gridHeight) * CellSize);
                }
            } while (snake.CheckCollision(Food.Instance.Position));
        }

        public void CheckWalls(Snake snake)
        {
            if (snake.Position.X > gridWidth * CellSize || snake.Position.X < 0 ||
                snake.Position.Y > gridHeight * CellSize || snake.Position.Y < 0)
            {                
                LoseGame();
            }
        }

        private void LoseGame()
        {
            gameHasStarted = false;
            DialogResult dialog = MessageBox.Show("You've lost!\nFinal score: " + snake.Score);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            var canvas = e.Graphics;
            Food food = Food.Instance;

            canvas.FillRectangle(Brushes.Red, food.Position.X, food.Position.Y, CellSize, CellSize);

            canvas.FillRectangle(Brushes.Gray, snake.Position.X, snake.Position.Y, CellSize, CellSize);
            foreach (var part in snake.Body)
            {
                canvas.FillRectangle(GridWorld.snakeColor, part.X, part.Y, CellSize, CellSize);
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (snake.Direction != SnakeDirection.Right)
                    {
                        snake.Direction = SnakeDirection.Left;
                    }
                    break;
                case Keys.Right:
                    if (snake.Direction != SnakeDirection.Left)
                    {
                        snake.Direction = SnakeDirection.Right;
                    }
                    break;
                case Keys.Up:
                    if (snake.Direction != SnakeDirection.Down)
                    {
                        snake.Direction = SnakeDirection.Up;
                    }
                    break;
                case Keys.Down:
                    if (snake.Direction != SnakeDirection.Up)
                    {
                        snake.Direction = SnakeDirection.Down;
                    }
                    break;
            }
        }

    }
}
