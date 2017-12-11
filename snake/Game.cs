using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace snake
{
	class Game
	{
		GameConfig gameConfig;
		Snake snake;
		Food food;
		Graphics gp = null;
		System.Timers.Timer t = null;
		Random r;
		int score;

		//delegate
		public delegate void ScoreChangedHandler(int score);
		public event ScoreChangedHandler ScoreChange;

		//Ingp -> picturebox
		public Game()
		{
			gameConfig = new GameConfig();
			snake = new Snake();
			food = new Food();
			score = 0;
			r = new Random();

		}

		public void InitGraphic(Graphics Ingp)
		{
			gp = Ingp;
		}

		public void fun()
		{
			ScoreChange(score);
		}
		public void GameStart()
		{
			//如果已经开始，则不响应此操作。
			if (GameConfig.GameStart == false)
			{
				if (t != null)
				{
					t.Dispose();
				}

				switch (GameConfig.Difficulty)
				{
					case GameConfig._difficulty.Easy:
						{
							t = new System.Timers.Timer(200);
							break;
						}
					case GameConfig._difficulty.Normal:
						{
							t = new System.Timers.Timer(100);
							break;
						}
					case GameConfig._difficulty.Hard:
						{
							t = new System.Timers.Timer(50);
							break;
						}
				}

				t.AutoReset = true;
				t.Elapsed += TimerEvent;

				Console.WriteLine("game start");
				GameConfig.GameStart = true;
				GameConfig.GameOver = false;
				snake = new Snake();
				food = new Food();
				score = 0;
				ScoreChange(score);
				t.Start();
			}
		}

		public void ResizeWindow(FormMain p)
		{
			//reset form size
			switch (GameConfig.MapSize)
			{
				case GameConfig._mapsize.Small:
					{
						p.Width = GameConfig.formsize[0].X;
						p.Height = GameConfig.formsize[0].Y;
						break;
					}
				case GameConfig._mapsize.Medium:
					{
						p.Width = GameConfig.formsize[1].X;
						p.Height = GameConfig.formsize[1].Y;
						break;
					}
				case GameConfig._mapsize.Big:
					{
						p.Width = GameConfig.formsize[2].X;
						p.Height = GameConfig.formsize[2].Y;
						break;
					}
			}
			p.pictureBoxMain.Width = (int)GameConfig.MapSize * GameConfig.BlockSize;
			p.pictureBoxMain.Height = (int)GameConfig.MapSize * GameConfig.BlockSize;
		}

		private void PaintGame()
		{
			gp.Clear(Color.FromKnownColor(KnownColor.Control));

			if (GameConfig.GameOver == false)
			{
				if (food.IfEaten())
				{
					Console.WriteLine("food eaten");
					score += GameConfig.GamePoint;
					ScoreChange?.Invoke(score);
				}
				food.MakeFood().Paint(gp);
				foreach (var body in snake.Move())
				{
					body.Paint(gp);
				}
			}
			else
			{
				Console.WriteLine("game over！！");
				t.Enabled = false;
				//重置snake
				snake.Reset();
				//使得下局重置food位置
				Food.Eaten = true;
				

			}

		}

		private void TimerEvent(object source, System.Timers.ElapsedEventArgs e)
		{
			PaintGame();
		}

		public Snake._direction SnakeDirection
		{
			get => snake.OldDirection;
			set
			{
				snake.Direction = value;
			}
		}
	}
}
