using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidisSimpleFaceRec
{
	public class button : Control
	{
		public button()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			DoubleBuffered = true;


			Size = new System.Drawing.Size(100, 30);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Graphics graph = e.Graphics;
			graph.SmoothingMode = SmoothingMode.HighQuality;

			graph.Clear(Parent.BackColor);

			Rectangle rect = new Rectangle(0, 0, Width -1 , Height- 1);

			graph.DrawRectangle(new Pen(BackColor), rect);
		}
	}
}
