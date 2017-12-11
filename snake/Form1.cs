using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
	public partial class FormMain : Form
	{
		Game game;

		public FormMain()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//exit the program
			this.Dispose();
			System.Environment.Exit(0);
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//about form show
			aboutForm aboutform = new aboutForm();
			aboutform.ShowDialog(this);
		}

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//setting form show
			settingForm settingform = new settingForm(this);
			settingform.ShowDialog(this);
		}

		private void FormMain_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				//start the game
				case Keys.Enter:
					{
						game.InitGraphic(Graphics.FromHwnd(pictureBoxMain.Handle));
						game.GameStart();
						break;
					}
				//control the snake
				case Keys.Up:
					{
						if(game.SnakeDirection != Snake._direction.Down)
						{
							game.SnakeDirection = Snake._direction.Up;
						}
						break;
					}
				case Keys.Down:
					{
						if (game.SnakeDirection != Snake._direction.Up)
						{
							game.SnakeDirection = Snake._direction.Down;
						}
						break;
					}
				case Keys.Left:
					{
						if (game.SnakeDirection != Snake._direction.Right)
						{
							game.SnakeDirection = Snake._direction.Left;
						}
						break;
					}
				case Keys.Right:
					{
						if (game.SnakeDirection != Snake._direction.Left)
						{
							game.SnakeDirection = Snake._direction.Right;
						}
						break;
					}
			}
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			game = new Game();
			game.ScoreChange += new Game.ScoreChangedHandler(UpdateScore);
			FormMainResizeWindow();

			Console.WriteLine(DateTime.Now);
		}

		//提供给setting form使用
		public void FormMainResizeWindow()
		{
			game.ResizeWindow(this);
		}

		private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
		{
			Console.WriteLine("[DEBUG] pictureBoxMain_Paint");
		}

		//delegate update score label
		public void UpdateScore(int score)
		{
			if (lblScore.InvokeRequired)
			{
				Game.ScoreChangedHandler sch = new Game.ScoreChangedHandler(UpdateScore);
				this.Invoke(sch, new object[] { score });
			}
			else
			{
				lblScore.Text = score.ToString();
			}
		}
	}
}
