using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficalGame
{
	public partial class FormMain : Form
	{
		

		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}



		private void BoxClick(object sender, EventArgs e)
		{
			PictureBox clickedBox = sender as PictureBox;

			if(clickedBox != null)
			{
				if(clickedBox.BackColor == Color.White)
				{
					clickedBox.BackColor = Color.Green;
				}
				else
				{
					clickedBox.BackColor = Color.White;
				}
			}
		}

		private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
		{

		}
	}
}
