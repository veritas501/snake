using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Snake
	{
		static List<Block> Body;
		Random r;

		public enum _direction
		{
			Up,
			Down,
			Left,
			Right
		}

		public _direction OldDirection;
		public _direction Direction;

		public Snake()
		{
			r = new Random();
			Body = new List<Block>();
			Body.Add(new Block(Color.Red, GameConfig.BlockSize, new Point(r.Next((int)GameConfig.MapSize), r.Next((int)GameConfig.MapSize))));
			Direction = _direction.Down;
			OldDirection = Direction;
		}

		public void Reset()
		{
			Body = new List<Block>();
			Body.Add(new Block(Color.Red, GameConfig.BlockSize, new Point(r.Next((int)GameConfig.MapSize), r.Next((int)GameConfig.MapSize))));
			Direction = _direction.Down;
			OldDirection = Direction;
		}

		public static bool InBody(Point p)
		{
			foreach (var b in Body)
			{
				if(b.Point == p)
				{
					return true;
				}
			}
			return false;
		}

		public List<Block> Move()
		{
			Block head = Body[0];
			Point Next = new Point(head.Point.X, head.Point.Y);

			switch (Direction)
			{
				case _direction.Down:
					{
						Next.Y += 1;
						break;
					}
				case _direction.Up:
					{
						Next.Y -= 1;
						break;
					}
				case _direction.Left:
					{
						Next.X -= 1;
						break;
					}
				case _direction.Right:
					{
						Next.X += 1;
						break;
					}
			}

			if (Next.X < 0 || Next.Y < 0 || Next.X >= (int)GameConfig.MapSize || Next.Y >= (int)GameConfig.MapSize)
			{
				GameConfig.GameOver = true;
				GameConfig.GameStart = false;
			}

			if (InBody(Next))
			{
				GameConfig.GameOver = true;
				GameConfig.GameStart = false;
			}

			Block NextBlock = new Block(Color.Red, GameConfig.BlockSize, Next);
						Body.Insert(0, NextBlock);

			//如果没有吃到食物，则尾部减一
			if (Next != Food.block.Point)
			{
				Body.RemoveAt(Body.Count - 1);
			}
			else
			{
				Food.Eaten = true;
			}

			OldDirection = Direction;

			return Body;
		}
	}
}
