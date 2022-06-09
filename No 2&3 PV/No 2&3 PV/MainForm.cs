/*
 * Created by SharpDevelop.
 * User: dk
 * Date: 6/7/2022
 * Time: 12:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV2_LAB
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if(progressBar1.Value==100)
			{
				timer1.Enabled = false;
				Form1 formhome = new Form1();
				formhome.Show();
				Hide();
			}
			
			else 
			{
				progressBar1.Value +=2;
			}
		}
	}
}
