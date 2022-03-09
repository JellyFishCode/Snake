
namespace Snake
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startLabel = new System.Windows.Forms.Label();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.cellTextField = new System.Windows.Forms.TextBox();
            this.labelCellSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.speedTextField = new System.Windows.Forms.TextBox();
            this.labelSnakeColor = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelGridSize = new System.Windows.Forms.Label();
            this.widthTextField = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.heightTextField = new System.Windows.Forms.TextBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Yellow;
            this.startLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.startLabel.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startLabel.Location = new System.Drawing.Point(119, 29);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(144, 33);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "New Game";
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.Location = new System.Drawing.Point(142, 403);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(75, 23);
            this.buttonGameStart.TabIndex = 1;
            this.buttonGameStart.Text = "Start";
            this.buttonGameStart.UseVisualStyleBackColor = true;
            this.buttonGameStart.Click += new System.EventHandler(this.buttonStartGame);
            // 
            // cellTextField
            // 
            this.cellTextField.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellTextField.Location = new System.Drawing.Point(194, 192);
            this.cellTextField.Name = "cellTextField";
            this.cellTextField.Size = new System.Drawing.Size(84, 28);
            this.cellTextField.TabIndex = 7;
            this.cellTextField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cellSizeTextFieldMouseMove);
            // 
            // labelCellSize
            // 
            this.labelCellSize.AutoSize = true;
            this.labelCellSize.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCellSize.Location = new System.Drawing.Point(86, 199);
            this.labelCellSize.Name = "labelCellSize";
            this.labelCellSize.Size = new System.Drawing.Size(66, 21);
            this.labelCellSize.TabIndex = 8;
            this.labelCellSize.Text = "Cellsize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Game settings will be set to default,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = " if there\'s no applicable value set.";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeed.Location = new System.Drawing.Point(86, 232);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(56, 21);
            this.labelSpeed.TabIndex = 12;
            this.labelSpeed.Text = "Speed";
            // 
            // speedTextField
            // 
            this.speedTextField.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedTextField.Location = new System.Drawing.Point(194, 225);
            this.speedTextField.Name = "speedTextField";
            this.speedTextField.Size = new System.Drawing.Size(84, 28);
            this.speedTextField.TabIndex = 11;
            // 
            // labelSnakeColor
            // 
            this.labelSnakeColor.AutoSize = true;
            this.labelSnakeColor.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSnakeColor.Location = new System.Drawing.Point(86, 264);
            this.labelSnakeColor.Name = "labelSnakeColor";
            this.labelSnakeColor.Size = new System.Drawing.Size(98, 21);
            this.labelSnakeColor.TabIndex = 14;
            this.labelSnakeColor.Text = "Snake-color";
            // 
            // labelGridSize
            // 
            this.labelGridSize.AutoSize = true;
            this.labelGridSize.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGridSize.Location = new System.Drawing.Point(86, 91);
            this.labelGridSize.Name = "labelGridSize";
            this.labelGridSize.Size = new System.Drawing.Size(74, 21);
            this.labelGridSize.TabIndex = 16;
            this.labelGridSize.Text = "Gridsize";
            // 
            // widthTextField
            // 
            this.widthTextField.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthTextField.Location = new System.Drawing.Point(145, 118);
            this.widthTextField.Name = "widthTextField";
            this.widthTextField.Size = new System.Drawing.Size(46, 28);
            this.widthTextField.TabIndex = 15;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWidth.Location = new System.Drawing.Point(86, 125);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(53, 21);
            this.labelWidth.TabIndex = 17;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeight.Location = new System.Drawing.Point(208, 125);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(59, 21);
            this.labelHeight.TabIndex = 18;
            this.labelHeight.Text = "Height";
            // 
            // heightTextField
            // 
            this.heightTextField.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heightTextField.Location = new System.Drawing.Point(273, 118);
            this.heightTextField.Name = "heightTextField";
            this.heightTextField.Size = new System.Drawing.Size(46, 28);
            this.heightTextField.TabIndex = 19;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.BlueViolet;
            this.colorDialog1.FullOpen = true;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(194, 264);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(84, 23);
            this.colorButton.TabIndex = 20;
            this.colorButton.Text = "Pick Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.PickColor);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.heightTextField);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelGridSize);
            this.Controls.Add(this.widthTextField);
            this.Controls.Add(this.labelSnakeColor);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.speedTextField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCellSize);
            this.Controls.Add(this.cellTextField);
            this.Controls.Add(this.buttonGameStart);
            this.Controls.Add(this.startLabel);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.TextBox cellTextField;
        private System.Windows.Forms.Label labelCellSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox speedTextField;
        private System.Windows.Forms.Label labelSnakeColor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelGridSize;
        private System.Windows.Forms.TextBox widthTextField;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox heightTextField;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorButton;
    }
}