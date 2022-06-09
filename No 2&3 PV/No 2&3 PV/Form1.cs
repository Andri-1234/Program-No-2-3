/*
 * Created by SharpDevelop.
 * User: dk
 * Date: 6/7/2022
 * Time: 1:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV2_LAB
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		private int Count=0;
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 frmChild = new Form2();
			frmChild.MdiParent = this;
			frmChild.Show();
			frmChild.Text += "ChildForm #"+Count.ToString();
			Count++;
		}
		void CascadeToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		void HorizontalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		void VerticalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
		
		
		
		
		
		
	}
}
