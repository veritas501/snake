using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Food
	{
		private Random r;
		private Point Position;
		public static Block block;
		public static bool Eaten;
		public Food()
		{
			r = new Random(DateTime.Now.Millisecond);
			Position = new Point();
			Position.X = r.Next((int)GameConfig.MapSize);
			Position.Y = r.Next((int)GameConfig.MapSize);
			block = new Block(Color.Green, GameConfig.BlockSize, Position);

			Eaten = false;
		}

		public Block MakeFood()
		{
			if (Eaten)
			{
				//防止相同

				Position.X = r.Next((int)GameConfig.MapSize);
				Position.Y = r.Next((int)GameConfig.MapSize);

				while (Snake.InBody(Position))
				{
					Console.WriteLine("food in body");
					Position.X = r.Next((int)GameConfig.MapSize);
					Position.Y = r.Next((int)GameConfig.MapSize);
				}

				block = new Block(Color.Green, GameConfig.BlockSize, Position);
				Eaten = false;
			}

			return block;
		}

		public bool IfEaten()
		{
			if (Eaten)
			{
				return true;
			}
			return false;
		}

	}
}
