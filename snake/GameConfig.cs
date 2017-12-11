using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class GameConfig
	{
		public enum _mapsize
		{
			Small=20,
			Medium=30,
			Big=50
		}

		public enum _difficulty
		{
			Easy,
			Normal,
			Hard
		}

		public static List<Point> formsize = new List<Point>
		{
			new Point(320,280),
			new Point(420,380),
			new Point(620,580)
		};

		public static int GamePoint { get; set; }

		public static _mapsize MapSize { get; set; }
		public static _difficulty Difficulty { get; set; }

		public static int BlockSize { get; set; }

		public static bool GameStart { get; set; }
		public static bool GameOver { get; set; }

		public GameConfig()
		{
			MapSize = _mapsize.Medium;
			Difficulty = _difficulty.Normal;
			BlockSize = 10;
			GameStart = false;
			GameOver = true;
			GamePoint = 100;
		}

	}
}
