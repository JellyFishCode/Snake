using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void buttonStartGame(object sender, EventArgs e)
        {
            // 
            if (cellTextField != null && int.TryParse(cellTextField.Text, out int value))
            {
                GridWorld.cellSize = value;
            }
            if (speedTextField != null && int.TryParse(cellTextField.Text, out int speedValue))
            {
                GridWorld.speed = speedValue;
            }
            Close();
        }

        private void cellSizeTextFieldMouseHover(object sender, EventArgs e)
        {
            cellTextField.Text += "mousehover";
        }

        private void cellSizeTextFieldMouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(cellTextField, "Defines the size of one grid in pixel. Default: 10");
            toolTip2.SetToolTip(speedTextField, "Specify speed. Default: 1");
            toolTip3.SetToolTip(colorButton, "Bodycolor of the snake. Default: Black");
        }

        private void PickColor(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                GridWorld.snakeColor = new SolidBrush(colorDialog1.Color);
            }
        }
    }
}
