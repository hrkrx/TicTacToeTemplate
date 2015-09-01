using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
	public partial class frmTicTacToe : Form
	{
		Button[] btArray = new Button[9];

		public frmTicTacToe()
		{
			InitializeComponent();

			btArray[0] = bt00;
			btArray[1] = bt01;
			btArray[2] = bt02;
			btArray[3] = bt10;
			btArray[4] = bt11;
			btArray[5] = bt12;
			btArray[6] = bt20;
			btArray[7] = bt21;
			btArray[8] = bt22;

			for (int i = 0; i < btArray.Length; i++) {
				btArray[i].Click += frmTicTacToe_Click;
			}
		}

		void frmTicTacToe_Click(object sender, EventArgs e)
		{
			// sender is the Button which was clicked
			Button clicked = (Button)sender;
			clicked.Text = "X";
			MessageBox.Show(clicked.Name + " was clicked!");
		}
	}
}
