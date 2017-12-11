using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Block
	{
		private Color _color;
		private int _size;
		private Point _point;

		public Block(Color color,int size,Point point)
		{
			_color = color;
			_size = size;
			_point = point;
		}

		public Point Point
		{
			get { return _point; }
		}

		public virtual void Paint(Graphics g)
		{
			SolidBrush sb = new SolidBrush(_color);
			lock (g)
			{
				try
				{
					//size-1是为了产生蛇一节节的效果
					g.FillRectangle(
						sb,
						_point.X * _size,
						_point.Y * _size,
						_size - 1,
						_size - 1);
				}
				catch (Exception ex)
				{
					Console.WriteLine("Paint Exception: " + ex);
					throw;
				}
			}
		}
	}
}
